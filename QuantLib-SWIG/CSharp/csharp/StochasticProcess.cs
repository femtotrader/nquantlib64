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

public class StochasticProcess : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StochasticProcess(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StochasticProcess obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StochasticProcess() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_StochasticProcess(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_StochasticProcess __deref__() {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.StochasticProcess___deref__(swigCPtr);
    SWIGTYPE_p_StochasticProcess ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_StochasticProcess(cPtr, false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isNull() {
    bool ret = NQuantLibcPINVOKE.StochasticProcess_isNull(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Observable asObservable() {
    Observable ret = new Observable(NQuantLibcPINVOKE.StochasticProcess_asObservable(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StochasticProcess() : this(NQuantLibcPINVOKE.new_StochasticProcess(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint size() {
    uint ret = NQuantLibcPINVOKE.StochasticProcess_size(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint factors() {
    uint ret = NQuantLibcPINVOKE.StochasticProcess_factors(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QlArray initialValues() {
    QlArray ret = new QlArray(NQuantLibcPINVOKE.StochasticProcess_initialValues(swigCPtr), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QlArray drift(double t, QlArray x) {
    QlArray ret = new QlArray(NQuantLibcPINVOKE.StochasticProcess_drift(swigCPtr, t, QlArray.getCPtr(x)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix diffusion(double t, QlArray x) {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.StochasticProcess_diffusion(swigCPtr, t, QlArray.getCPtr(x)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QlArray expectation(double t0, QlArray x0, double dt) {
    QlArray ret = new QlArray(NQuantLibcPINVOKE.StochasticProcess_expectation(swigCPtr, t0, QlArray.getCPtr(x0), dt), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix stdDeviation(double t0, QlArray x0, double dt) {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.StochasticProcess_stdDeviation(swigCPtr, t0, QlArray.getCPtr(x0), dt), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Matrix covariance(double t0, QlArray x0, double dt) {
    Matrix ret = new Matrix(NQuantLibcPINVOKE.StochasticProcess_covariance(swigCPtr, t0, QlArray.getCPtr(x0), dt), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public QlArray evolve(double t0, QlArray x0, double dt, QlArray dw) {
    QlArray ret = new QlArray(NQuantLibcPINVOKE.StochasticProcess_evolve(swigCPtr, t0, QlArray.getCPtr(x0), dt, QlArray.getCPtr(dw)), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
