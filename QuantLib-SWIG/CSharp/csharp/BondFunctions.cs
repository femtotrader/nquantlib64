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

public class BondFunctions : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BondFunctions(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(BondFunctions obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~BondFunctions() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_BondFunctions(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static Date startDate(Bond bond) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_startDate(Bond.getCPtr(bond)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date maturityDate(Bond bond) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_maturityDate(Bond.getCPtr(bond)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isTradable(Bond bond, Date settlementDate) {
    bool ret = NQuantLibcPINVOKE.BondFunctions_isTradable__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static bool isTradable(Bond bond) {
    bool ret = NQuantLibcPINVOKE.BondFunctions_isTradable__SWIG_1(Bond.getCPtr(bond));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date previousCashFlowDate(Bond bond, Date refDate) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_previousCashFlowDate__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(refDate)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date previousCashFlowDate(Bond bond) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_previousCashFlowDate__SWIG_1(Bond.getCPtr(bond)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextCashFlowDate(Bond bond, Date refDate) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_nextCashFlowDate__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(refDate)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date nextCashFlowDate(Bond bond) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_nextCashFlowDate__SWIG_1(Bond.getCPtr(bond)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double previousCashFlowAmount(Bond bond, Date refDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_previousCashFlowAmount__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(refDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double previousCashFlowAmount(Bond bond) {
    double ret = NQuantLibcPINVOKE.BondFunctions_previousCashFlowAmount__SWIG_1(Bond.getCPtr(bond));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double nextCashFlowAmount(Bond bond, Date refDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_nextCashFlowAmount__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(refDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double nextCashFlowAmount(Bond bond) {
    double ret = NQuantLibcPINVOKE.BondFunctions_nextCashFlowAmount__SWIG_1(Bond.getCPtr(bond));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double previousCouponRate(Bond bond, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_previousCouponRate__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double previousCouponRate(Bond bond) {
    double ret = NQuantLibcPINVOKE.BondFunctions_previousCouponRate__SWIG_1(Bond.getCPtr(bond));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double nextCouponRate(Bond bond, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_nextCouponRate__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double nextCouponRate(Bond bond) {
    double ret = NQuantLibcPINVOKE.BondFunctions_nextCouponRate__SWIG_1(Bond.getCPtr(bond));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date accrualStartDate(Bond bond, Date settlementDate) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_accrualStartDate__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(settlementDate)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date accrualStartDate(Bond bond) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_accrualStartDate__SWIG_1(Bond.getCPtr(bond)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date accrualEndDate(Bond bond, Date settlementDate) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_accrualEndDate__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(settlementDate)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Date accrualEndDate(Bond bond) {
    Date ret = new Date(NQuantLibcPINVOKE.BondFunctions_accrualEndDate__SWIG_1(Bond.getCPtr(bond)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double accrualPeriod(Bond bond, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_accrualPeriod__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double accrualPeriod(Bond bond) {
    double ret = NQuantLibcPINVOKE.BondFunctions_accrualPeriod__SWIG_1(Bond.getCPtr(bond));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int accrualDays(Bond bond, Date settlementDate) {
    int ret = NQuantLibcPINVOKE.BondFunctions_accrualDays__SWIG_0(Bond.getCPtr(bond), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static int accrualDays(Bond bond) {
    int ret = NQuantLibcPINVOKE.BondFunctions_accrualDays__SWIG_1(Bond.getCPtr(bond));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cleanPrice(Bond bond, YieldTermStructure discountCurve, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_cleanPrice__SWIG_0(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cleanPrice(Bond bond, YieldTermStructure discountCurve) {
    double ret = NQuantLibcPINVOKE.BondFunctions_cleanPrice__SWIG_1(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Bond bond, YieldTermStructure discountCurve, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_bps__SWIG_0(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Bond bond, YieldTermStructure discountCurve) {
    double ret = NQuantLibcPINVOKE.BondFunctions_bps__SWIG_1(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double atmRate(Bond bond, YieldTermStructure discountCurve, Date settlementDate, double cleanPrice) {
    double ret = NQuantLibcPINVOKE.BondFunctions_atmRate__SWIG_0(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve), Date.getCPtr(settlementDate), cleanPrice);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double atmRate(Bond bond, YieldTermStructure discountCurve, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_atmRate__SWIG_1(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double atmRate(Bond bond, YieldTermStructure discountCurve) {
    double ret = NQuantLibcPINVOKE.BondFunctions_atmRate__SWIG_2(Bond.getCPtr(bond), YieldTermStructure.getCPtr(discountCurve));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cleanPrice(Bond bond, InterestRate yield, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_cleanPrice__SWIG_2(Bond.getCPtr(bond), InterestRate.getCPtr(yield), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cleanPrice(Bond bond, InterestRate yield) {
    double ret = NQuantLibcPINVOKE.BondFunctions_cleanPrice__SWIG_3(Bond.getCPtr(bond), InterestRate.getCPtr(yield));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cleanPrice(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_cleanPrice__SWIG_4(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double cleanPrice(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency) {
    double ret = NQuantLibcPINVOKE.BondFunctions_cleanPrice__SWIG_5(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Bond bond, InterestRate yield, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_bps__SWIG_2(Bond.getCPtr(bond), InterestRate.getCPtr(yield), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Bond bond, InterestRate yield) {
    double ret = NQuantLibcPINVOKE.BondFunctions_bps__SWIG_3(Bond.getCPtr(bond), InterestRate.getCPtr(yield));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_bps__SWIG_4(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double bps(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency) {
    double ret = NQuantLibcPINVOKE.BondFunctions_bps__SWIG_5(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Bond bond, double cleanPrice, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate, double accuracy, uint maxIterations, double guess) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yield__SWIG_0(Bond.getCPtr(bond), cleanPrice, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate), accuracy, maxIterations, guess);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Bond bond, double cleanPrice, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate, double accuracy, uint maxIterations) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yield__SWIG_1(Bond.getCPtr(bond), cleanPrice, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate), accuracy, maxIterations);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Bond bond, double cleanPrice, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate, double accuracy) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yield__SWIG_2(Bond.getCPtr(bond), cleanPrice, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate), accuracy);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Bond bond, double cleanPrice, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yield__SWIG_3(Bond.getCPtr(bond), cleanPrice, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yield(Bond bond, double cleanPrice, DayCounter dayCounter, Compounding compounding, Frequency frequency) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yield__SWIG_4(Bond.getCPtr(bond), cleanPrice, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Bond bond, InterestRate yield, Duration.Type type, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_duration__SWIG_0(Bond.getCPtr(bond), InterestRate.getCPtr(yield), (int)type, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Bond bond, InterestRate yield, Duration.Type type) {
    double ret = NQuantLibcPINVOKE.BondFunctions_duration__SWIG_1(Bond.getCPtr(bond), InterestRate.getCPtr(yield), (int)type);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Bond bond, InterestRate yield) {
    double ret = NQuantLibcPINVOKE.BondFunctions_duration__SWIG_2(Bond.getCPtr(bond), InterestRate.getCPtr(yield));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Duration.Type type, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_duration__SWIG_3(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, (int)type, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Duration.Type type) {
    double ret = NQuantLibcPINVOKE.BondFunctions_duration__SWIG_4(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, (int)type);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double duration(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency) {
    double ret = NQuantLibcPINVOKE.BondFunctions_duration__SWIG_5(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Bond bond, InterestRate yield, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_convexity__SWIG_0(Bond.getCPtr(bond), InterestRate.getCPtr(yield), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Bond bond, InterestRate yield) {
    double ret = NQuantLibcPINVOKE.BondFunctions_convexity__SWIG_1(Bond.getCPtr(bond), InterestRate.getCPtr(yield));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_convexity__SWIG_2(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double convexity(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency) {
    double ret = NQuantLibcPINVOKE.BondFunctions_convexity__SWIG_3(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Bond bond, InterestRate yield, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_basisPointValue__SWIG_0(Bond.getCPtr(bond), InterestRate.getCPtr(yield), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Bond bond, InterestRate yield) {
    double ret = NQuantLibcPINVOKE.BondFunctions_basisPointValue__SWIG_1(Bond.getCPtr(bond), InterestRate.getCPtr(yield));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_basisPointValue__SWIG_2(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double basisPointValue(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency) {
    double ret = NQuantLibcPINVOKE.BondFunctions_basisPointValue__SWIG_3(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yieldValueBasisPoint(Bond bond, InterestRate yield, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yieldValueBasisPoint__SWIG_0(Bond.getCPtr(bond), InterestRate.getCPtr(yield), Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yieldValueBasisPoint(Bond bond, InterestRate yield) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yieldValueBasisPoint__SWIG_1(Bond.getCPtr(bond), InterestRate.getCPtr(yield));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yieldValueBasisPoint(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yieldValueBasisPoint__SWIG_2(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double yieldValueBasisPoint(Bond bond, double yield, DayCounter dayCounter, Compounding compounding, Frequency frequency) {
    double ret = NQuantLibcPINVOKE.BondFunctions_yieldValueBasisPoint__SWIG_3(Bond.getCPtr(bond), yield, DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Bond bond, double cleanPrice, YieldTermStructure discountCurve, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate, double accuracy, uint maxIterations, double guess) {
    double ret = NQuantLibcPINVOKE.BondFunctions_zSpread__SWIG_0(Bond.getCPtr(bond), cleanPrice, YieldTermStructure.getCPtr(discountCurve), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate), accuracy, maxIterations, guess);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Bond bond, double cleanPrice, YieldTermStructure discountCurve, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate, double accuracy, uint maxIterations) {
    double ret = NQuantLibcPINVOKE.BondFunctions_zSpread__SWIG_1(Bond.getCPtr(bond), cleanPrice, YieldTermStructure.getCPtr(discountCurve), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate), accuracy, maxIterations);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Bond bond, double cleanPrice, YieldTermStructure discountCurve, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate, double accuracy) {
    double ret = NQuantLibcPINVOKE.BondFunctions_zSpread__SWIG_2(Bond.getCPtr(bond), cleanPrice, YieldTermStructure.getCPtr(discountCurve), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate), accuracy);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Bond bond, double cleanPrice, YieldTermStructure discountCurve, DayCounter dayCounter, Compounding compounding, Frequency frequency, Date settlementDate) {
    double ret = NQuantLibcPINVOKE.BondFunctions_zSpread__SWIG_3(Bond.getCPtr(bond), cleanPrice, YieldTermStructure.getCPtr(discountCurve), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency, Date.getCPtr(settlementDate));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static double zSpread(Bond bond, double cleanPrice, YieldTermStructure discountCurve, DayCounter dayCounter, Compounding compounding, Frequency frequency) {
    double ret = NQuantLibcPINVOKE.BondFunctions_zSpread__SWIG_4(Bond.getCPtr(bond), cleanPrice, YieldTermStructure.getCPtr(discountCurve), DayCounter.getCPtr(dayCounter), (int)compounding, (int)frequency);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BondFunctions() : this(NQuantLibcPINVOKE.new_BondFunctions(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
