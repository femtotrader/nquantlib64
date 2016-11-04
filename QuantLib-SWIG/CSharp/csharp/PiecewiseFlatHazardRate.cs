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

public class PiecewiseFlatHazardRate : DefaultProbabilityTermStructure {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PiecewiseFlatHazardRate(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.PiecewiseFlatHazardRate_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PiecewiseFlatHazardRate obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PiecewiseFlatHazardRate() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_PiecewiseFlatHazardRate(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PiecewiseFlatHazardRate(Date referenceDate, DefaultProbabilityHelperVector instruments, DayCounter dayCounter, double accuracy, BackwardFlat i) : this(NQuantLibcPINVOKE.new_PiecewiseFlatHazardRate__SWIG_0(Date.getCPtr(referenceDate), DefaultProbabilityHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), accuracy, BackwardFlat.getCPtr(i)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseFlatHazardRate(Date referenceDate, DefaultProbabilityHelperVector instruments, DayCounter dayCounter, double accuracy) : this(NQuantLibcPINVOKE.new_PiecewiseFlatHazardRate__SWIG_1(Date.getCPtr(referenceDate), DefaultProbabilityHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseFlatHazardRate(Date referenceDate, DefaultProbabilityHelperVector instruments, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_PiecewiseFlatHazardRate__SWIG_2(Date.getCPtr(referenceDate), DefaultProbabilityHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseFlatHazardRate(int settlementDays, Calendar calendar, DefaultProbabilityHelperVector instruments, DayCounter dayCounter, double accuracy, BackwardFlat i) : this(NQuantLibcPINVOKE.new_PiecewiseFlatHazardRate__SWIG_3(settlementDays, Calendar.getCPtr(calendar), DefaultProbabilityHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), accuracy, BackwardFlat.getCPtr(i)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseFlatHazardRate(int settlementDays, Calendar calendar, DefaultProbabilityHelperVector instruments, DayCounter dayCounter, double accuracy) : this(NQuantLibcPINVOKE.new_PiecewiseFlatHazardRate__SWIG_4(settlementDays, Calendar.getCPtr(calendar), DefaultProbabilityHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter), accuracy), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public PiecewiseFlatHazardRate(int settlementDays, Calendar calendar, DefaultProbabilityHelperVector instruments, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_PiecewiseFlatHazardRate__SWIG_5(settlementDays, Calendar.getCPtr(calendar), DefaultProbabilityHelperVector.getCPtr(instruments), DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DateVector dates() {
    DateVector ret = new DateVector(NQuantLibcPINVOKE.PiecewiseFlatHazardRate_dates(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DoubleVector times() {
    DoubleVector ret = new DoubleVector(NQuantLibcPINVOKE.PiecewiseFlatHazardRate_times(swigCPtr), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public NodeVector nodes() {
    NodeVector ret = new NodeVector(NQuantLibcPINVOKE.PiecewiseFlatHazardRate_nodes(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
