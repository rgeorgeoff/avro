// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace jc.analytics
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Nonce : SpecificFixed
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"fixed\",\"name\":\"Nonce\",\"namespace\":\"jc.analytics\",\"size\":16}");
		private static uint fixedSize = 16;
		public Nonce() : 
				base(fixedSize)
		{
		}
		public override Schema Schema
		{
			get
			{
				return Nonce._SCHEMA;
			}
		}
		public static uint FixedSize
		{
			get
			{
				return Nonce.fixedSize;
			}
		}
	}
}
