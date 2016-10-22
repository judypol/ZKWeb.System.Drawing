﻿#if CORECLR
namespace System
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Delegate, Inherited = false)]
	internal sealed class SerializableAttribute : Attribute
	{
		public SerializableAttribute() { }
	}
}
#endif
