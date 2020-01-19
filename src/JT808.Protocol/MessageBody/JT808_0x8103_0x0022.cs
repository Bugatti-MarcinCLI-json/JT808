﻿using System.Text.Json;
using JT808.Protocol.Attributes;
using JT808.Protocol.Extensions;
using JT808.Protocol.Formatters;
using JT808.Protocol.Interfaces;
using JT808.Protocol.MessagePack;

namespace JT808.Protocol.MessageBody
{
    /// <summary>
    /// 驾驶员未登录汇报时间间隔，单位为秒（s），>0
    /// </summary>
    public class JT808_0x8103_0x0022 : JT808_0x8103_BodyBase, IJT808MessagePackFormatter<JT808_0x8103_0x0022>, IJT808Analyze
    {
        public override uint ParamId { get; set; } = 0x0022;
        /// <summary>
        /// 数据 长度
        /// </summary>
        public override byte ParamLength { get; set; } = 4;
        /// <summary>
        /// 驾驶员未登录汇报时间间隔，单位为秒（s），>0
        /// </summary>
        public uint ParamValue { get; set; }

        public void Analyze(ref JT808MessagePackReader reader, Utf8JsonWriter writer, IJT808Config config)
        {
            JT808_0x8103_0x0022 jT808_0x8103_0x0022 = new JT808_0x8103_0x0022();
            jT808_0x8103_0x0022.ParamId = reader.ReadUInt32();
            jT808_0x8103_0x0022.ParamLength = reader.ReadByte();
            jT808_0x8103_0x0022.ParamValue = reader.ReadUInt32();
            writer.WriteNumber($"[{ jT808_0x8103_0x0022.ParamId.ReadNumber()}]参数ID", jT808_0x8103_0x0022.ParamId);
            writer.WriteNumber($"[{jT808_0x8103_0x0022.ParamLength.ReadNumber()}]参数长度", jT808_0x8103_0x0022.ParamLength);
            writer.WriteNumber($"[{ jT808_0x8103_0x0022.ParamValue.ReadNumber()}]参数值", jT808_0x8103_0x0022.ParamValue);
        }

        public JT808_0x8103_0x0022 Deserialize(ref JT808MessagePackReader reader, IJT808Config config)
        {
            JT808_0x8103_0x0022 jT808_0x8103_0x0022 = new JT808_0x8103_0x0022();
            jT808_0x8103_0x0022.ParamId = reader.ReadUInt32();
            jT808_0x8103_0x0022.ParamLength = reader.ReadByte();
            jT808_0x8103_0x0022.ParamValue = reader.ReadUInt32();
            return jT808_0x8103_0x0022;
        }

        public void Serialize(ref JT808MessagePackWriter writer, JT808_0x8103_0x0022 value, IJT808Config config)
        {
            writer.WriteUInt32(value.ParamId);
            writer.WriteByte(value.ParamLength);
            writer.WriteUInt32(value.ParamValue);
        }
    }
}
