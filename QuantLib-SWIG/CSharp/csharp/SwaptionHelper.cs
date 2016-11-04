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

public class SwaptionHelper : CalibrationHelper {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal SwaptionHelper(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.SwaptionHelper_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SwaptionHelper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SwaptionHelper() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_SwaptionHelper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SwaptionHelper(Period maturity, Period length, QuoteHandle volatility, IborIndex index, Period fixedLegTenor, DayCounter fixedLegDayCounter, DayCounter floatingLegDayCounter, YieldTermStructureHandle termStructure, _CalibrationHelper.CalibrationErrorType errorType) : this(NQuantLibcPINVOKE.new_SwaptionHelper__SWIG_0(Period.getCPtr(maturity), Period.getCPtr(length), QuoteHandle.getCPtr(volatility), IborIndex.getCPtr(index), Period.getCPtr(fixedLegTenor), DayCounter.getCPtr(fixedLegDayCounter), DayCounter.getCPtr(floatingLegDayCounter), YieldTermStructureHandle.getCPtr(termStructure), (int)errorType), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public SwaptionHelper(Period maturity, Period length, QuoteHandle volatility, IborIndex index, Period fixedLegTenor, DayCounter fixedLegDayCounter, DayCounter floatingLegDayCounter, YieldTermStructureHandle termStructure) : this(NQuantLibcPINVOKE.new_SwaptionHelper__SWIG_1(Period.getCPtr(maturity), Period.getCPtr(length), QuoteHandle.getCPtr(volatility), IborIndex.getCPtr(index), Period.getCPtr(fixedLegTenor), DayCounter.getCPtr(fixedLegDayCounter), DayCounter.getCPtr(floatingLegDayCounter), YieldTermStructureHandle.getCPtr(termStructure)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DoubleVector times() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.SwaptionHelper_times(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
