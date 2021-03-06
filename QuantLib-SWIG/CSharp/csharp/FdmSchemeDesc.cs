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

public class FdmSchemeDesc : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FdmSchemeDesc(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FdmSchemeDesc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FdmSchemeDesc() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_FdmSchemeDesc(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FdmSchemeDesc(FdmSchemeDesc.FdmSchemeType type, double theta, double mu) : this(NQuantLibcPINVOKE.new_FdmSchemeDesc((int)type, theta, mu), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public FdmSchemeDesc.FdmSchemeType type {
    get {
      FdmSchemeDesc.FdmSchemeType ret = (FdmSchemeDesc.FdmSchemeType)NQuantLibcPINVOKE.FdmSchemeDesc_type_get(swigCPtr);
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double theta {
    get {
      double ret = NQuantLibcPINVOKE.FdmSchemeDesc_theta_get(swigCPtr);
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public double mu {
    get {
      double ret = NQuantLibcPINVOKE.FdmSchemeDesc_mu_get(swigCPtr);
      if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public static FdmSchemeDesc Douglas() {
    FdmSchemeDesc ret = new FdmSchemeDesc(NQuantLibcPINVOKE.FdmSchemeDesc_Douglas(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FdmSchemeDesc ImplicitEuler() {
    FdmSchemeDesc ret = new FdmSchemeDesc(NQuantLibcPINVOKE.FdmSchemeDesc_ImplicitEuler(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FdmSchemeDesc ExplicitEuler() {
    FdmSchemeDesc ret = new FdmSchemeDesc(NQuantLibcPINVOKE.FdmSchemeDesc_ExplicitEuler(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FdmSchemeDesc CraigSneyd() {
    FdmSchemeDesc ret = new FdmSchemeDesc(NQuantLibcPINVOKE.FdmSchemeDesc_CraigSneyd(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FdmSchemeDesc ModifiedCraigSneyd() {
    FdmSchemeDesc ret = new FdmSchemeDesc(NQuantLibcPINVOKE.FdmSchemeDesc_ModifiedCraigSneyd(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FdmSchemeDesc Hundsdorfer() {
    FdmSchemeDesc ret = new FdmSchemeDesc(NQuantLibcPINVOKE.FdmSchemeDesc_Hundsdorfer(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static FdmSchemeDesc ModifiedHundsdorfer() {
    FdmSchemeDesc ret = new FdmSchemeDesc(NQuantLibcPINVOKE.FdmSchemeDesc_ModifiedHundsdorfer(), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum FdmSchemeType {
    HundsdorferType,
    DouglasType,
    CraigSneydType,
    ModifiedCraigSneydType,
    ImplicitEulerType,
    ExplicitEulerType
  }

}

}
