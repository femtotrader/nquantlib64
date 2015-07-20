//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QuantLib {

public class CreditDefaultSwap : Instrument {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal CreditDefaultSwap(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.CreditDefaultSwap_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CreditDefaultSwap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CreditDefaultSwap() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CreditDefaultSwap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CreditDefaultSwap(Protection.Side side, double notional, double spread, Schedule schedule, BusinessDayConvention paymentConvention, DayCounter dayCounter, bool settlesAccrual, bool paysAtDefaultTime) : this(NQuantLibcPINVOKE.new_CreditDefaultSwap__SWIG_0((int)side, notional, spread, Schedule.getCPtr(schedule), (int)paymentConvention, DayCounter.getCPtr(dayCounter), settlesAccrual, paysAtDefaultTime), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CreditDefaultSwap(Protection.Side side, double notional, double spread, Schedule schedule, BusinessDayConvention paymentConvention, DayCounter dayCounter, bool settlesAccrual) : this(NQuantLibcPINVOKE.new_CreditDefaultSwap__SWIG_1((int)side, notional, spread, Schedule.getCPtr(schedule), (int)paymentConvention, DayCounter.getCPtr(dayCounter), settlesAccrual), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CreditDefaultSwap(Protection.Side side, double notional, double spread, Schedule schedule, BusinessDayConvention paymentConvention, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_CreditDefaultSwap__SWIG_2((int)side, notional, spread, Schedule.getCPtr(schedule), (int)paymentConvention, DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CreditDefaultSwap(Protection.Side side, double notional, double upfront, double spread, Schedule schedule, BusinessDayConvention paymentConvention, DayCounter dayCounter, bool settlesAccrual, bool paysAtDefaultTime) : this(NQuantLibcPINVOKE.new_CreditDefaultSwap__SWIG_3((int)side, notional, upfront, spread, Schedule.getCPtr(schedule), (int)paymentConvention, DayCounter.getCPtr(dayCounter), settlesAccrual, paysAtDefaultTime), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CreditDefaultSwap(Protection.Side side, double notional, double upfront, double spread, Schedule schedule, BusinessDayConvention paymentConvention, DayCounter dayCounter, bool settlesAccrual) : this(NQuantLibcPINVOKE.new_CreditDefaultSwap__SWIG_4((int)side, notional, upfront, spread, Schedule.getCPtr(schedule), (int)paymentConvention, DayCounter.getCPtr(dayCounter), settlesAccrual), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public CreditDefaultSwap(Protection.Side side, double notional, double upfront, double spread, Schedule schedule, BusinessDayConvention paymentConvention, DayCounter dayCounter) : this(NQuantLibcPINVOKE.new_CreditDefaultSwap__SWIG_5((int)side, notional, upfront, spread, Schedule.getCPtr(schedule), (int)paymentConvention, DayCounter.getCPtr(dayCounter)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public Protection.Side side() {
    Protection.Side ret = (Protection.Side)NQuantLibcPINVOKE.CreditDefaultSwap_side(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double notional() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_notional(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double runningSpread() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_runningSpread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double upfront() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_upfront(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool settlesAccrual() {
    bool ret = NQuantLibcPINVOKE.CreditDefaultSwap_settlesAccrual(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool paysAtDefaultTime() {
    bool ret = NQuantLibcPINVOKE.CreditDefaultSwap_paysAtDefaultTime(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fairSpread() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_fairSpread(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double fairUpfront() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_fairUpfront(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double couponLegBPS() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_couponLegBPS(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double couponLegNPV() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_couponLegNPV(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double defaultLegNPV() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_defaultLegNPV(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double upfrontBPS() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_upfrontBPS(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double upfrontNPV() {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_upfrontNPV(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedHazardRate(double targetNPV, YieldTermStructureHandle discountCurve, DayCounter dayCounter, double recoveryRate, double accuracy) {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_impliedHazardRate__SWIG_0(swigCPtr, targetNPV, YieldTermStructureHandle.getCPtr(discountCurve), DayCounter.getCPtr(dayCounter), recoveryRate, accuracy);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedHazardRate(double targetNPV, YieldTermStructureHandle discountCurve, DayCounter dayCounter, double recoveryRate) {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_impliedHazardRate__SWIG_1(swigCPtr, targetNPV, YieldTermStructureHandle.getCPtr(discountCurve), DayCounter.getCPtr(dayCounter), recoveryRate);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedHazardRate(double targetNPV, YieldTermStructureHandle discountCurve, DayCounter dayCounter) {
    double ret = NQuantLibcPINVOKE.CreditDefaultSwap_impliedHazardRate__SWIG_2(swigCPtr, targetNPV, YieldTermStructureHandle.getCPtr(discountCurve), DayCounter.getCPtr(dayCounter));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Leg coupons() {
    Leg ret = new Leg(NQuantLibcPINVOKE.CreditDefaultSwap_coupons(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}