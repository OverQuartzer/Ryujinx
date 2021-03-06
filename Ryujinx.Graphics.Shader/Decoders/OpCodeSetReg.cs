using Ryujinx.Graphics.Shader.Instructions;

namespace Ryujinx.Graphics.Shader.Decoders
{
    class OpCodeSetReg : OpCodeSet, IOpCodeReg
    {
        public Register Rb { get; protected set; }

        public OpCodeSetReg(InstEmitter emitter, ulong address, long opCode) : base(emitter, address, opCode)
        {
            Rb = new Register(opCode.Extract(20, 8), RegisterType.Gpr);
        }
    }
}