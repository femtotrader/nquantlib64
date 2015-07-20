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

public class RelinkableQuoteHandleVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IList<RelinkableQuoteHandle>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RelinkableQuoteHandleVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RelinkableQuoteHandleVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RelinkableQuoteHandleVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NQuantLibcPINVOKE.delete_RelinkableQuoteHandleVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public RelinkableQuoteHandleVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (RelinkableQuoteHandle element in c) {
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

  public RelinkableQuoteHandle this[int index]  {
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

  public void CopyTo(RelinkableQuoteHandle[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(RelinkableQuoteHandle[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, RelinkableQuoteHandle[] array, int arrayIndex, int count)
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

  global::System.Collections.Generic.IEnumerator<RelinkableQuoteHandle> global::System.Collections.Generic.IEnumerable<RelinkableQuoteHandle>.GetEnumerator() {
    return new RelinkableQuoteHandleVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new RelinkableQuoteHandleVectorEnumerator(this);
  }

  public RelinkableQuoteHandleVectorEnumerator GetEnumerator() {
    return new RelinkableQuoteHandleVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class RelinkableQuoteHandleVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<RelinkableQuoteHandle>
  {
    private RelinkableQuoteHandleVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public RelinkableQuoteHandleVectorEnumerator(RelinkableQuoteHandleVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public RelinkableQuoteHandle Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (RelinkableQuoteHandle)currentObject;
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
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_Clear(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Add(RelinkableQuoteHandle x) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_Add(swigCPtr, RelinkableQuoteHandle.getCPtr(x));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = NQuantLibcPINVOKE.RelinkableQuoteHandleVector_size(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private uint capacity() {
    uint ret = NQuantLibcPINVOKE.RelinkableQuoteHandleVector_capacity(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void reserve(uint n) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_reserve(swigCPtr, n);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableQuoteHandleVector() : this(NQuantLibcPINVOKE.new_RelinkableQuoteHandleVector__SWIG_0(), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableQuoteHandleVector(RelinkableQuoteHandleVector other) : this(NQuantLibcPINVOKE.new_RelinkableQuoteHandleVector__SWIG_1(RelinkableQuoteHandleVector.getCPtr(other)), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableQuoteHandleVector(int capacity) : this(NQuantLibcPINVOKE.new_RelinkableQuoteHandleVector__SWIG_2(capacity), true) {
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  private RelinkableQuoteHandle getitemcopy(int index) {
    RelinkableQuoteHandle ret = new RelinkableQuoteHandle(NQuantLibcPINVOKE.RelinkableQuoteHandleVector_getitemcopy(swigCPtr, index), true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private RelinkableQuoteHandle getitem(int index) {
    RelinkableQuoteHandle ret = new RelinkableQuoteHandle(NQuantLibcPINVOKE.RelinkableQuoteHandleVector_getitem(swigCPtr, index), false);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, RelinkableQuoteHandle val) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_setitem(swigCPtr, index, RelinkableQuoteHandle.getCPtr(val));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(RelinkableQuoteHandleVector values) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_AddRange(swigCPtr, RelinkableQuoteHandleVector.getCPtr(values));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public RelinkableQuoteHandleVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.RelinkableQuoteHandleVector_GetRange(swigCPtr, index, count);
    RelinkableQuoteHandleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new RelinkableQuoteHandleVector(cPtr, true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, RelinkableQuoteHandle x) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_Insert(swigCPtr, index, RelinkableQuoteHandle.getCPtr(x));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, RelinkableQuoteHandleVector values) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_InsertRange(swigCPtr, index, RelinkableQuoteHandleVector.getCPtr(values));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_RemoveAt(swigCPtr, index);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_RemoveRange(swigCPtr, index, count);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public static RelinkableQuoteHandleVector Repeat(RelinkableQuoteHandle value, int count) {
    global::System.IntPtr cPtr = NQuantLibcPINVOKE.RelinkableQuoteHandleVector_Repeat(RelinkableQuoteHandle.getCPtr(value), count);
    RelinkableQuoteHandleVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new RelinkableQuoteHandleVector(cPtr, true);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_Reverse__SWIG_0(swigCPtr);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Reverse(int index, int count) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, RelinkableQuoteHandleVector values) {
    NQuantLibcPINVOKE.RelinkableQuoteHandleVector_SetRange(swigCPtr, index, RelinkableQuoteHandleVector.getCPtr(values));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool Contains(RelinkableQuoteHandle value) {
    bool ret = NQuantLibcPINVOKE.RelinkableQuoteHandleVector_Contains(swigCPtr, RelinkableQuoteHandle.getCPtr(value));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int IndexOf(RelinkableQuoteHandle value) {
    int ret = NQuantLibcPINVOKE.RelinkableQuoteHandleVector_IndexOf(swigCPtr, RelinkableQuoteHandle.getCPtr(value));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LastIndexOf(RelinkableQuoteHandle value) {
    int ret = NQuantLibcPINVOKE.RelinkableQuoteHandleVector_LastIndexOf(swigCPtr, RelinkableQuoteHandle.getCPtr(value));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Remove(RelinkableQuoteHandle value) {
    bool ret = NQuantLibcPINVOKE.RelinkableQuoteHandleVector_Remove(swigCPtr, RelinkableQuoteHandle.getCPtr(value));
    if (NQuantLibcPINVOKE.SWIGPendingException.Pending) throw NQuantLibcPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}