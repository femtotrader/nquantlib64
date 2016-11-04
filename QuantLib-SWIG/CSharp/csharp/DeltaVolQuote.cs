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

public class DeltaVolQuote : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DeltaVolQuote(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DeltaVolQuote obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DeltaVolQuote() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_DeltaVolQuote(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public _DeltaVolQuote __deref__() {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.DeltaVolQuote___deref__(swigCPtr);
    _DeltaVolQuote ret = (cPtr == global::System.IntPtr.Zero) ? null : new _DeltaVolQuote(cPtr, false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isNull() {
    bool ret = NQuantLibcPINVOKE.DeltaVolQuote_isNull(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.DeltaVolQuote_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DeltaVolQuote(double delta, QuoteHandle vol, double maturity, _DeltaVolQuote.DeltaType deltaType) : this(NQuantLibcPINVOKE.new_DeltaVolQuote__SWIG_0(delta, QuoteHandle.getCPtr(vol), maturity, (int)deltaType), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DeltaVolQuote(QuoteHandle vol, _DeltaVolQuote.DeltaType deltaType, double maturity, _DeltaVolQuote.AtmType atmType) : this(NQuantLibcPINVOKE.new_DeltaVolQuote__SWIG_1(QuoteHandle.getCPtr(vol), (int)deltaType, maturity, (int)atmType), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public double value() {
    double ret = NQuantLibcPINVOKE.DeltaVolQuote_value(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static readonly _DeltaVolQuote.DeltaType Spot = (_DeltaVolQuote.DeltaType)NQuantLibcPINVOKE.DeltaVolQuote_Spot_get();
  public static readonly _DeltaVolQuote.DeltaType Fwd = (_DeltaVolQuote.DeltaType)NQuantLibcPINVOKE.DeltaVolQuote_Fwd_get();
  public static readonly _DeltaVolQuote.DeltaType PaSpot = (_DeltaVolQuote.DeltaType)NQuantLibcPINVOKE.DeltaVolQuote_PaSpot_get();
  public static readonly _DeltaVolQuote.DeltaType PaFwd = (_DeltaVolQuote.DeltaType)NQuantLibcPINVOKE.DeltaVolQuote_PaFwd_get();
  public static readonly _DeltaVolQuote.AtmType AtmNull = (_DeltaVolQuote.AtmType)NQuantLibcPINVOKE.DeltaVolQuote_AtmNull_get();
  public static readonly _DeltaVolQuote.AtmType AtmSpot = (_DeltaVolQuote.AtmType)NQuantLibcPINVOKE.DeltaVolQuote_AtmSpot_get();
  public static readonly _DeltaVolQuote.AtmType AtmFwd = (_DeltaVolQuote.AtmType)NQuantLibcPINVOKE.DeltaVolQuote_AtmFwd_get();
  public static readonly _DeltaVolQuote.AtmType AtmDeltaNeutral = (_DeltaVolQuote.AtmType)NQuantLibcPINVOKE.DeltaVolQuote_AtmDeltaNeutral_get();
  public static readonly _DeltaVolQuote.AtmType AtmVegaMax = (_DeltaVolQuote.AtmType)NQuantLibcPINVOKE.DeltaVolQuote_AtmVegaMax_get();
  public static readonly _DeltaVolQuote.AtmType AtmGammaMax = (_DeltaVolQuote.AtmType)NQuantLibcPINVOKE.DeltaVolQuote_AtmGammaMax_get();
  public static readonly _DeltaVolQuote.AtmType AtmPutCall50 = (_DeltaVolQuote.AtmType)NQuantLibcPINVOKE.DeltaVolQuote_AtmPutCall50_get();
}

}
