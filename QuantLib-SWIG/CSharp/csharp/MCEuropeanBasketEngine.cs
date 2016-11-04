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

public class MCEuropeanBasketEngine : PricingEngine {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MCEuropeanBasketEngine(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NQuantLibcPINVOKE.MCEuropeanBasketEngine_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MCEuropeanBasketEngine obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MCEuropeanBasketEngine() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_MCEuropeanBasketEngine(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits, uint timeSteps, uint timeStepsPerYear, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance, int maxSamples, int seed) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_0(StochasticProcessArray.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance, maxSamples, seed), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits, uint timeSteps, uint timeStepsPerYear, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance, int maxSamples) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_1(StochasticProcessArray.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance, maxSamples), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits, uint timeSteps, uint timeStepsPerYear, bool brownianBridge, bool antitheticVariate, int requiredSamples, double requiredTolerance) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_2(StochasticProcessArray.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate, requiredSamples, requiredTolerance), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits, uint timeSteps, uint timeStepsPerYear, bool brownianBridge, bool antitheticVariate, int requiredSamples) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_3(StochasticProcessArray.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate, requiredSamples), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits, uint timeSteps, uint timeStepsPerYear, bool brownianBridge, bool antitheticVariate) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_4(StochasticProcessArray.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge, antitheticVariate), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits, uint timeSteps, uint timeStepsPerYear, bool brownianBridge) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_5(StochasticProcessArray.getCPtr(process), traits, timeSteps, timeStepsPerYear, brownianBridge), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits, uint timeSteps, uint timeStepsPerYear) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_6(StochasticProcessArray.getCPtr(process), traits, timeSteps, timeStepsPerYear), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits, uint timeSteps) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_7(StochasticProcessArray.getCPtr(process), traits, timeSteps), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public MCEuropeanBasketEngine(StochasticProcessArray process, string traits) : this(NQuantLibcPINVOKE.new_MCEuropeanBasketEngine__SWIG_8(StochasticProcessArray.getCPtr(process), traits), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
