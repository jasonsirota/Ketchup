﻿using System;
using Ketchup.Protocol;

namespace Ketchup.Async {

	public static class ReplaceExtensions {

		public static KetchupClient Replace<T>(this KetchupClient client, string key, T value, Action success = null, Action<Exception> error = null) {
			return Replace(client, key, value, DateTime.MinValue, success, error);
		}

		public static KetchupClient Replace<T>(this KetchupClient client, string key, T value, TimeSpan expiration, Action success = null, Action<Exception> error = null) {
			//memcached treats timespans greater than 30 days as unix epoch time, convert to datetime
			if (expiration.TotalDays > 30)
				Replace(client, key, value, DateTime.UtcNow + expiration, success, error);

			Operations.SetAddReplace(Op.Replace, key, value, expiration.Seconds, client.Bucket, success, error);
			return client;
		}

		public static KetchupClient Replace<T>(this KetchupClient client, string key, T value, DateTime expiration, Action success = null, Action<Exception> error = null) {
			var exp = expiration == DateTime.MinValue ? 0 : (expiration - new DateTime(1970, 1, 1)).Seconds;
			Operations.SetAddReplace(Op.Replace, key, value, exp, client.Bucket, success, error);
			return client;
		}

	}
}
