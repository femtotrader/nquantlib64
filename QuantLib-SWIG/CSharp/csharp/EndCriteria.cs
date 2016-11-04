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

public class EndCriteria : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal EndCriteria(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EndCriteria obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EndCriteria() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_EndCriteria(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public EndCriteria(uint maxIteration, uint maxStationaryStateIterations, double rootEpsilon, double functionEpsilon, double gradientNormEpsilon) : this(NQuantLibcPINVOKE.new_EndCriteria(maxIteration, maxStationaryStateIterations, rootEpsilon, functionEpsilon, gradientNormEpsilon), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool call(uint iteration, SWIGTYPE_p_std__size_t statState, bool positiveOptimization, double fold, double normgold, double fnew, double normgnewx, SWIGTYPE_p_EndCriteria__Type ecType) {
    bool ret = NQuantLibcPINVOKE.EndCriteria_call(swigCPtr, iteration, SWIGTYPE_p_std__size_t.getCPtr(statState), positiveOptimization, fold, normgold, fnew, normgnewx, SWIGTYPE_p_EndCriteria__Type.getCPtr(ecType));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum Type {
    None,
    MaxIterations,
    StationaryPoint,
    StationaryFunctionValue,
    StationaryFunctionAccuracy,
    ZeroGradientNorm,
    Unknown
  }

}

}
