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

public class CalibrationHelper : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CalibrationHelper(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CalibrationHelper obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CalibrationHelper() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_CalibrationHelper(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public _CalibrationHelper __deref__() {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.CalibrationHelper___deref__(swigCPtr);
    _CalibrationHelper ret = (cPtr == global::System.IntPtr.Zero) ? null : new _CalibrationHelper(cPtr, false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isNull() {
    bool ret = NQuantLibcPINVOKE.CalibrationHelper_isNull(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public CalibrationHelper() : this(NQuantLibcPINVOKE.new_CalibrationHelper(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPricingEngine(PricingEngine engine) {
    NQuantLibcPINVOKE.CalibrationHelper_setPricingEngine(swigCPtr, PricingEngine.getCPtr(engine));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double marketValue() {
    double ret = NQuantLibcPINVOKE.CalibrationHelper_marketValue(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double modelValue() {
    double ret = NQuantLibcPINVOKE.CalibrationHelper_modelValue(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double calibrationError() {
    double ret = NQuantLibcPINVOKE.CalibrationHelper_calibrationError(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double impliedVolatility(double targetValue, double accuracy, uint maxEvaluations, double minVol, double maxVol) {
    double ret = NQuantLibcPINVOKE.CalibrationHelper_impliedVolatility(swigCPtr, targetValue, accuracy, maxEvaluations, minVol, maxVol);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public double blackPrice(double volatility) {
    double ret = NQuantLibcPINVOKE.CalibrationHelper_blackPrice(swigCPtr, volatility);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly _CalibrationHelper.CalibrationErrorType RelativePriceError = (_CalibrationHelper.CalibrationErrorType)NQuantLibcPINVOKE.CalibrationHelper_RelativePriceError_get();
  public static readonly _CalibrationHelper.CalibrationErrorType PriceError = (_CalibrationHelper.CalibrationErrorType)NQuantLibcPINVOKE.CalibrationHelper_PriceError_get();
  public static readonly _CalibrationHelper.CalibrationErrorType ImpliedVolError = (_CalibrationHelper.CalibrationErrorType)NQuantLibcPINVOKE.CalibrationHelper_ImpliedVolError_get();
}

}
