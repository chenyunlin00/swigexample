//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Person : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Person(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Person obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Person() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          mymodulePINVOKE.delete_Person(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Person(string name) : this(mymodulePINVOKE.new_Person(name), true) {
    if (mymodulePINVOKE.SWIGPendingException.Pending) throw mymodulePINVOKE.SWIGPendingException.Retrieve();
  }

  public string _name {
    set {
      mymodulePINVOKE.Person__name_set(swigCPtr, value);
      if (mymodulePINVOKE.SWIGPendingException.Pending) throw mymodulePINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = mymodulePINVOKE.Person__name_get(swigCPtr);
      if (mymodulePINVOKE.SWIGPendingException.Pending) throw mymodulePINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}
