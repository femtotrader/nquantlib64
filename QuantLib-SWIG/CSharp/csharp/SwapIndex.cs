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

public class SwapIndex : InterestRateIndex {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SwapIndex(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.SwapIndex_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SwapIndex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SwapIndex() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_SwapIndex(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SwapIndex(string familyName, Period tenor, int settlementDays, Currency currency, Calendar calendar, Period fixedLegTenor, BusinessDayConvention fixedLegConvention, DayCounter fixedLegDayCounter, IborIndex iborIndex) : this(NQuantLibcPINVOKE.new_SwapIndex__SWIG_0(familyName, Period.getCPtr(tenor), settlementDays, Currency.getCPtr(currency), Calendar.getCPtr(calendar), Period.getCPtr(fixedLegTenor), (int)fixedLegConvention, DayCounter.getCPtr(fixedLegDayCounter), IborIndex.getCPtr(iborIndex)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwapIndex(string familyName, Period tenor, int settlementDays, Currency currency, Calendar calendar, Period fixedLegTenor, BusinessDayConvention fixedLegConvention, DayCounter fixedLegDayCounter, IborIndex iborIndex, YieldTermStructureHandle discountCurve) : this(NQuantLibcPINVOKE.new_SwapIndex__SWIG_1(familyName, Period.getCPtr(tenor), settlementDays, Currency.getCPtr(currency), Calendar.getCPtr(calendar), Period.getCPtr(fixedLegTenor), (int)fixedLegConvention, DayCounter.getCPtr(fixedLegDayCounter), IborIndex.getCPtr(iborIndex), YieldTermStructureHandle.getCPtr(discountCurve)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Period fixedLegTenor() {
    Period ret = new Period(NQuantLibcPINVOKE.SwapIndex_fixedLegTenor(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BusinessDayConvention fixedLegConvention() {
    BusinessDayConvention ret = (BusinessDayConvention)NQuantLibcPINVOKE.SwapIndex_fixedLegConvention(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public IborIndex iborIndex() {
    IborIndex ret = new IborIndex(NQuantLibcPINVOKE.SwapIndex_iborIndex(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public YieldTermStructureHandle forwardingTermStructure() {
    YieldTermStructureHandle ret = new YieldTermStructureHandle(NQuantLibcPINVOKE.SwapIndex_forwardingTermStructure(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
