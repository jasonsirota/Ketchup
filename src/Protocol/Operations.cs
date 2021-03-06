﻿//using System;
//using Ketchup.Config;
//using Ketchup.Hashing;
//using Ketchup.Protocol.Exceptions;
//using System.Diagnostics;
//using Ketchup.Protocol.Operations;

//namespace Ketchup.Protocol
//{
//    internal static class Operations
//    {
//        //public static void Delete(Op operation, string key, string bucket, Action success, Action<Exception> error)
//        //{
//        //    var packet = new Packet<string>(operation, config.GetPrefixKey(key, bucket));
//        //    Hasher.GetNode(key, bucket).Request(packet.Serialize(), rb =>
//        //    {
//        //        try
//        //        {
//        //            packet.Deserialize(rb);
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            if (error != null) error(ex);
//        //        }
//        //    });
//        //}

//        //public static void IncrDecr(Op operation, string key, long initial, long step, int expiration, string bucket, Action<long> success, Action<Exception> error)
//        //{
//        //    var extras = new byte[20];
//        //    step.CopyTo(extras, 0);
//        //    initial.CopyTo(extras, 8);
//        //    expiration.CopyTo(extras, 16);

//        //    var packet = new Packet<long>(operation, config.GetPrefixKey(key, bucket)).Extras(extras);
//        //    Hasher.GetNode(key, bucket).Request(packet.Serialize(), rb =>
//        //    {
//        //        try
//        //        {
//        //            success(packet.Deserialize(rb));
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            error(ex);
//        //        }
//        //    });
//        //}

//        ///// <summary>
//        ///// Quit assumes success unless an error is thrown
//        ///// </summary>
//        ///// <param name="success"></param>
//        ///// <param name="error"></param>
//        ///// <param name="operation"></param>
//        ///// <param name="node"></param>
//        //public static void QuitNoOp(Op operation, Node node, Action success, Action<Exception> error)
//        //{
//        //    var packet = new Packet<string>(operation, "");
//        //    node.Request(packet.Serialize(), rb =>
//        //    {
//        //        try
//        //        {
//        //            packet.Deserialize(rb);
//        //            success();
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            error(ex);
//        //        }
//        //    });
//        //}

//        //public static void Flush(Op operation, Node node, int expiration, Action success, Action<Exception> error)
//        //{
//        //    var extras = new byte[4];
//        //    expiration.CopyTo(extras, 0);

//        //    var packet = new Packet<string>(operation, "").Extras(extras);
//        //    node.Request(packet.Serialize(), rb =>
//        //    {
//        //        try
//        //        {
//        //            packet.Deserialize(rb);
//        //            success();
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            error(ex);
//        //        }
//        //    });
//        //}

//        //public static void Version(Op operation, Node node, Action<string> success, Action<Exception> error)
//        //{
//        //    var packet = new Packet<string>(operation, "");
//        //    node.Request(packet.Serialize(), rb =>
//        //    {
//        //        try
//        //        {
//        //            success(packet.Deserialize(rb));
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            error(ex);
//        //        }
//        //    });
//        //}

//        //public static void AppendPrepend(Op operation, string key, string value, string bucket, Action success, Action<Exception> error)
//        //{
//        //    key = config.GetPrefixKey(key, bucket);
//        //    var packet = new Packet<string>(operation, key).Value(value);

//        //    if (success != null && error != null)
//        //    {
//        //        Hasher.GetNode(key, bucket).Request(packet.Serialize(), rb =>
//        //        {
//        //            try
//        //            {
//        //                packet.Deserialize(rb);
//        //                success();
//        //            }
//        //            catch (Exception ex)
//        //            {
//        //                error(ex);
//        //            }
//        //        });
//        //    }
//        //    else
//        //    {
//        //        //shh...
//        //        Hasher.GetNode(key, bucket).Request(packet.Serialize(), null);
//        //    }
//        //}

//        //public static void Stat(Op operation, string key, string bucket, Node node, Action<string, string> each, Action complete, Action<Exception> error)
//        //{
//        //    var packet = new Packet<string>(Op.Stat, key);
//        //    key = config.GetPrefixKey(key, bucket);
//        //    node = string.IsNullOrEmpty(key) ? node : Hasher.GetNode(key, bucket);
//        //    node.Request(packet.Serialize(), rb =>
//        //    {
//        //        try
//        //        {
//        //            var value = packet.Deserialize(rb);
//        //            packet.Key(out key);
//        //            if (key == "" && value == "")
//        //                complete();
//        //            else
//        //                each(key, value);
//        //        }
//        //        catch (Exception ex)
//        //        {
//        //            error(ex);
//        //        }
//        //    });
//        //}
//    }
//}
