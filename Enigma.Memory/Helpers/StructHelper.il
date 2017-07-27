.class public auto ansi abstract sealed Enigma.Memory.StructHelper`1<T>
{
    .method public hidebysig static !T UnsafeRead(uint8[] 'buffer', int32 'offset') cil managed
    {
        .maxstack 2
        .locals init (
            [0] uint8& pinned pBuffer,
            [1] !T
        )

        IL_0000: ldarg.0
        IL_0001: ldarg.1
        IL_0002: ldelema [mscorlib]System.Byte
        IL_0007: stloc.0
        IL_0008: ldloc.0
        IL_0009: conv.i
        IL_000a: ldobj !T
        IL_000f: stloc.1
        IL_0010: leave.s IL_0012

        IL_0012: ldloc.1
        IL_0013: ret
    }
}
