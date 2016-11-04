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

public class DefaultProbabilityHelperVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<DefaultProbabilityHelper>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DefaultProbabilityHelperVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DefaultProbabilityHelperVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~DefaultProbabilityHelperVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_DefaultProbabilityHelperVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public DefaultProbabilityHelperVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (DefaultProbabilityHelper element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public DefaultProbabilityHelper this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(DefaultProbabilityHelper[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(DefaultProbabilityHelper[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, DefaultProbabilityHelper[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<DefaultProbabilityHelper> global::System.Collections.Generic.IEnumerable<DefaultProbabilityHelper>.GetEnumerator() {
    return new DefaultProbabilityHelperVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new DefaultProbabilityHelperVectorEnumerator(this);
  }

  public DefaultProbabilityHelperVectorEnumerator GetEnumerator() {
    return new DefaultProbabilityHelperVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class DefaultProbabilityHelperVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<DefaultProbabilityHelper>
  {
    private DefaultProbabilityHelperVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public DefaultProbabilityHelperVectorEnumerator(DefaultProbabilityHelperVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public DefaultProbabilityHelper Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (DefaultProbabilityHelper)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_Clear(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(DefaultProbabilityHelper x) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_Add(swigCPtr, DefaultProbabilityHelper.getCPtr(x));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = NQuantLibcPINVOKE.DefaultProbabilityHelperVector_size(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = NQuantLibcPINVOKE.DefaultProbabilityHelperVector_capacity(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_reserve(swigCPtr, n);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DefaultProbabilityHelperVector() : this(NQuantLibcPINVOKE.new_DefaultProbabilityHelperVector__SWIG_0(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DefaultProbabilityHelperVector(DefaultProbabilityHelperVector other) : this(NQuantLibcPINVOKE.new_DefaultProbabilityHelperVector__SWIG_1(DefaultProbabilityHelperVector.getCPtr(other)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DefaultProbabilityHelperVector(int capacity) : this(NQuantLibcPINVOKE.new_DefaultProbabilityHelperVector__SWIG_2(capacity), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  private DefaultProbabilityHelper getitemcopy(int index) {
    DefaultProbabilityHelper ret = new DefaultProbabilityHelper(NQuantLibcPINVOKE.DefaultProbabilityHelperVector_getitemcopy(swigCPtr, index), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private DefaultProbabilityHelper getitem(int index) {
    DefaultProbabilityHelper ret = new DefaultProbabilityHelper(NQuantLibcPINVOKE.DefaultProbabilityHelperVector_getitem(swigCPtr, index), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, DefaultProbabilityHelper val) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_setitem(swigCPtr, index, DefaultProbabilityHelper.getCPtr(val));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(DefaultProbabilityHelperVector values) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_AddRange(swigCPtr, DefaultProbabilityHelperVector.getCPtr(values));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public DefaultProbabilityHelperVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.DefaultProbabilityHelperVector_GetRange(swigCPtr, index, count);
    DefaultProbabilityHelperVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DefaultProbabilityHelperVector(cPtr, true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, DefaultProbabilityHelper x) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_Insert(swigCPtr, index, DefaultProbabilityHelper.getCPtr(x));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, DefaultProbabilityHelperVector values) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_InsertRange(swigCPtr, index, DefaultProbabilityHelperVector.getCPtr(values));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_RemoveAt(swigCPtr, index);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_RemoveRange(swigCPtr, index, count);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public static DefaultProbabilityHelperVector Repeat(DefaultProbabilityHelper value, int count) {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.DefaultProbabilityHelperVector_Repeat(DefaultProbabilityHelper.getCPtr(value), count);
    DefaultProbabilityHelperVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new DefaultProbabilityHelperVector(cPtr, true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_Reverse__SWIG_0(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, DefaultProbabilityHelperVector values) {
    NQuantLibcPINVOKE.DefaultProbabilityHelperVector_SetRange(swigCPtr, index, DefaultProbabilityHelperVector.getCPtr(values));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(DefaultProbabilityHelper value) {
    bool ret = NQuantLibcPINVOKE.DefaultProbabilityHelperVector_Contains(swigCPtr, DefaultProbabilityHelper.getCPtr(value));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(DefaultProbabilityHelper value) {
    int ret = NQuantLibcPINVOKE.DefaultProbabilityHelperVector_IndexOf(swigCPtr, DefaultProbabilityHelper.getCPtr(value));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(DefaultProbabilityHelper value) {
    int ret = NQuantLibcPINVOKE.DefaultProbabilityHelperVector_LastIndexOf(swigCPtr, DefaultProbabilityHelper.getCPtr(value));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(DefaultProbabilityHelper value) {
    bool ret = NQuantLibcPINVOKE.DefaultProbabilityHelperVector_Remove(swigCPtr, DefaultProbabilityHelper.getCPtr(value));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
