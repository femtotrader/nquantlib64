//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class RelinkableCapFloorTermVolatilityStructureHandle : CapFloorTermVolatilityStructureHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal RelinkableCapFloorTermVolatilityStructureHandle(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.RelinkableCapFloorTermVolatilityStructureHandle_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RelinkableCapFloorTermVolatilityStructureHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RelinkableCapFloorTermVolatilityStructureHandle() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_RelinkableCapFloorTermVolatilityStructureHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public RelinkableCapFloorTermVolatilityStructureHandle(CapFloorTermVolatilityStructure arg0) : this(NQuantLibcPINVOKE.new_RelinkableCapFloorTermVolatilityStructureHandle__SWIG_0(CapFloorTermVolatilityStructure.getCPtr(arg0)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableCapFloorTermVolatilityStructureHandle() : this(NQuantLibcPINVOKE.new_RelinkableCapFloorTermVolatilityStructureHandle__SWIG_1(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void linkTo(CapFloorTermVolatilityStructure arg0) {
    NQuantLibcPINVOKE.RelinkableCapFloorTermVolatilityStructureHandle_linkTo(swigCPtr, CapFloorTermVolatilityStructure.getCPtr(arg0));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
