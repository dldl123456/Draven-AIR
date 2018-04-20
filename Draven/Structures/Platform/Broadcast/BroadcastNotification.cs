﻿namespace Draven.Structures.Platform.Broadcast
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    using Newtonsoft.Json;

    using RtmpSharp.IO;
    using RtmpSharp.IO.AMF3;

    [Serializable]
    [SerializedName("com.riotgames.platform.broadcast.BroadcastNotification")]
    public class BroadcastNotification : IExternalizable
    {
        public ArrayList broadcastMessages { get; set; }
        public string Json { get; set; }

        public void ReadExternal(IDataInput input)
        {
            this.Json = input.ReadUtf((int)input.ReadUInt32());
            Dictionary<string, object> deserializedJSON = JsonConvert.DeserializeObject<Dictionary<string, object>>(this.Json);
            Type classType = typeof(BroadcastNotification);
            foreach (KeyValuePair<string, object> keyPair in deserializedJSON)
            {
                var f = classType.GetProperty(keyPair.Key);
                //f.SetValue(this, keyPair.Value);
            }
        }

        public void WriteExternal(IDataOutput output)
        {
            var bytes = Encoding.UTF8.GetBytes(this.Json);

            output.WriteInt32(bytes.Length);
            output.WriteBytes(bytes);
        }
    }
}
