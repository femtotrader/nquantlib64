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

public class LocalConstantVol : LocalVolTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal LocalConstantVol(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.LocalConstantVol_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LocalConstantVol obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LocalConstantVol() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_LocalConstantVol(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public LocalConstantVol(Date referenceDate, double volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_LocalConstantVol__SWIG_0(Date.getCPtr(referenceDate), volatility, DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public LocalConstantVol(Date referenceDate, QuoteHandle volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_LocalConstantVol__SWIG_1(Date.getCPtr(referenceDate), QuoteHandle.getCPtr(volatility), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public LocalConstantVol(int settlementDays, Calendar calendar, double volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_LocalConstantVol__SWIG_2(settlementDays, Calendar.getCPtr(calendar), volatility, DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public LocalConstantVol(int settlementDays, Calendar calendar, QuoteHandle volatility, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_LocalConstantVol__SWIG_3(settlementDays, Calendar.getCPtr(calendar), QuoteHandle.getCPtr(volatility), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
