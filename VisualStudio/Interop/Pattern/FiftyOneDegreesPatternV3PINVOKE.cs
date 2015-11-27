//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FiftyOne.Mobile.Detection.Provider.Interop.Pattern {

class FiftyOneDegreesPatternV3PINVOKE {

  protected class SWIGExceptionHelper {

    public delegate void ExceptionDelegate(string message);
    public delegate void ExceptionArgumentDelegate(string message, string paramName);

    static ExceptionDelegate applicationDelegate = new ExceptionDelegate(SetPendingApplicationException);
    static ExceptionDelegate arithmeticDelegate = new ExceptionDelegate(SetPendingArithmeticException);
    static ExceptionDelegate divideByZeroDelegate = new ExceptionDelegate(SetPendingDivideByZeroException);
    static ExceptionDelegate indexOutOfRangeDelegate = new ExceptionDelegate(SetPendingIndexOutOfRangeException);
    static ExceptionDelegate invalidCastDelegate = new ExceptionDelegate(SetPendingInvalidCastException);
    static ExceptionDelegate invalidOperationDelegate = new ExceptionDelegate(SetPendingInvalidOperationException);
    static ExceptionDelegate ioDelegate = new ExceptionDelegate(SetPendingIOException);
    static ExceptionDelegate nullReferenceDelegate = new ExceptionDelegate(SetPendingNullReferenceException);
    static ExceptionDelegate outOfMemoryDelegate = new ExceptionDelegate(SetPendingOutOfMemoryException);
    static ExceptionDelegate overflowDelegate = new ExceptionDelegate(SetPendingOverflowException);
    static ExceptionDelegate systemDelegate = new ExceptionDelegate(SetPendingSystemException);

    static ExceptionArgumentDelegate argumentDelegate = new ExceptionArgumentDelegate(SetPendingArgumentException);
    static ExceptionArgumentDelegate argumentNullDelegate = new ExceptionArgumentDelegate(SetPendingArgumentNullException);
    static ExceptionArgumentDelegate argumentOutOfRangeDelegate = new ExceptionArgumentDelegate(SetPendingArgumentOutOfRangeException);

    [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="SWIGRegisterExceptionCallbacks_FiftyOneDegreesPatternV3")]
    public static extern void SWIGRegisterExceptionCallbacks_FiftyOneDegreesPatternV3(
                                ExceptionDelegate applicationDelegate,
                                ExceptionDelegate arithmeticDelegate,
                                ExceptionDelegate divideByZeroDelegate, 
                                ExceptionDelegate indexOutOfRangeDelegate, 
                                ExceptionDelegate invalidCastDelegate,
                                ExceptionDelegate invalidOperationDelegate,
                                ExceptionDelegate ioDelegate,
                                ExceptionDelegate nullReferenceDelegate,
                                ExceptionDelegate outOfMemoryDelegate, 
                                ExceptionDelegate overflowDelegate, 
                                ExceptionDelegate systemExceptionDelegate);

    [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="SWIGRegisterExceptionArgumentCallbacks_FiftyOneDegreesPatternV3")]
    public static extern void SWIGRegisterExceptionCallbacksArgument_FiftyOneDegreesPatternV3(
                                ExceptionArgumentDelegate argumentDelegate,
                                ExceptionArgumentDelegate argumentNullDelegate,
                                ExceptionArgumentDelegate argumentOutOfRangeDelegate);

    static void SetPendingApplicationException(string message) {
      SWIGPendingException.Set(new global::System.ApplicationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArithmeticException(string message) {
      SWIGPendingException.Set(new global::System.ArithmeticException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingDivideByZeroException(string message) {
      SWIGPendingException.Set(new global::System.DivideByZeroException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIndexOutOfRangeException(string message) {
      SWIGPendingException.Set(new global::System.IndexOutOfRangeException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidCastException(string message) {
      SWIGPendingException.Set(new global::System.InvalidCastException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingInvalidOperationException(string message) {
      SWIGPendingException.Set(new global::System.InvalidOperationException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingIOException(string message) {
      SWIGPendingException.Set(new global::System.IO.IOException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingNullReferenceException(string message) {
      SWIGPendingException.Set(new global::System.NullReferenceException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOutOfMemoryException(string message) {
      SWIGPendingException.Set(new global::System.OutOfMemoryException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingOverflowException(string message) {
      SWIGPendingException.Set(new global::System.OverflowException(message, SWIGPendingException.Retrieve()));
    }
    static void SetPendingSystemException(string message) {
      SWIGPendingException.Set(new global::System.SystemException(message, SWIGPendingException.Retrieve()));
    }

    static void SetPendingArgumentException(string message, string paramName) {
      SWIGPendingException.Set(new global::System.ArgumentException(message, paramName, SWIGPendingException.Retrieve()));
    }
    static void SetPendingArgumentNullException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentNullException(paramName, message));
    }
    static void SetPendingArgumentOutOfRangeException(string message, string paramName) {
      global::System.Exception e = SWIGPendingException.Retrieve();
      if (e != null) message = message + " Inner Exception: " + e.Message;
      SWIGPendingException.Set(new global::System.ArgumentOutOfRangeException(paramName, message));
    }

    static SWIGExceptionHelper() {
      SWIGRegisterExceptionCallbacks_FiftyOneDegreesPatternV3(
                                applicationDelegate,
                                arithmeticDelegate,
                                divideByZeroDelegate,
                                indexOutOfRangeDelegate,
                                invalidCastDelegate,
                                invalidOperationDelegate,
                                ioDelegate,
                                nullReferenceDelegate,
                                outOfMemoryDelegate,
                                overflowDelegate,
                                systemDelegate);

      SWIGRegisterExceptionCallbacksArgument_FiftyOneDegreesPatternV3(
                                argumentDelegate,
                                argumentNullDelegate,
                                argumentOutOfRangeDelegate);
    }
  }

  protected static SWIGExceptionHelper swigExceptionHelper = new SWIGExceptionHelper();

  public class SWIGPendingException {
    [global::System.ThreadStatic]
    private static global::System.Exception pendingException = null;
    private static int numExceptionsPending = 0;

    public static bool Pending {
      get {
        bool pending = false;
        if (numExceptionsPending > 0)
          if (pendingException != null)
            pending = true;
        return pending;
      } 
    }

    public static void Set(global::System.Exception e) {
      if (pendingException != null)
        throw new global::System.ApplicationException("FATAL: An earlier pending exception from unmanaged code was missed and thus not thrown (" + pendingException.ToString() + ")", e);
      pendingException = e;
      lock(typeof(FiftyOneDegreesPatternV3PINVOKE)) {
        numExceptionsPending++;
      }
    }

    public static global::System.Exception Retrieve() {
      global::System.Exception e = null;
      if (numExceptionsPending > 0) {
        if (pendingException != null) {
          e = pendingException;
          pendingException = null;
          lock(typeof(FiftyOneDegreesPatternV3PINVOKE)) {
            numExceptionsPending--;
          }
        }
      }
      return e;
    }
  }


  protected class SWIGStringHelper {

    public delegate string SWIGStringDelegate(string message);
    static SWIGStringDelegate stringDelegate = new SWIGStringDelegate(CreateString);

    [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="SWIGRegisterStringCallback_FiftyOneDegreesPatternV3")]
    public static extern void SWIGRegisterStringCallback_FiftyOneDegreesPatternV3(SWIGStringDelegate stringDelegate);

    static string CreateString(string cString) {
      return cString;
    }

    static SWIGStringHelper() {
      SWIGRegisterStringCallback_FiftyOneDegreesPatternV3(stringDelegate);
    }
  }

  static protected SWIGStringHelper swigStringHelper = new SWIGStringHelper();


  static FiftyOneDegreesPatternV3PINVOKE() {
  }


  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_MapStringString__SWIG_0")]
  public static extern global::System.IntPtr new_MapStringString__SWIG_0();

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_MapStringString__SWIG_1")]
  public static extern global::System.IntPtr new_MapStringString__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_size")]
  public static extern uint MapStringString_size(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_empty")]
  public static extern bool MapStringString_empty(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_Clear")]
  public static extern void MapStringString_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_getitem")]
  public static extern string MapStringString_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_setitem")]
  public static extern void MapStringString_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_ContainsKey")]
  public static extern bool MapStringString_ContainsKey(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_Add")]
  public static extern void MapStringString_Add(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_Remove")]
  public static extern bool MapStringString_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_create_iterator_begin")]
  public static extern global::System.IntPtr MapStringString_create_iterator_begin(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_get_next_key")]
  public static extern string MapStringString_get_next_key(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.IntPtr jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_MapStringString_destroy_iterator")]
  public static extern void MapStringString_destroy_iterator(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.IntPtr jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_delete_MapStringString")]
  public static extern void delete_MapStringString(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_Clear")]
  public static extern void VectorString_Clear(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_Add")]
  public static extern void VectorString_Add(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_size")]
  public static extern uint VectorString_size(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_capacity")]
  public static extern uint VectorString_capacity(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_reserve")]
  public static extern void VectorString_reserve(global::System.Runtime.InteropServices.HandleRef jarg1, uint jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_VectorString__SWIG_0")]
  public static extern global::System.IntPtr new_VectorString__SWIG_0();

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_VectorString__SWIG_1")]
  public static extern global::System.IntPtr new_VectorString__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_VectorString__SWIG_2")]
  public static extern global::System.IntPtr new_VectorString__SWIG_2(int jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_getitemcopy")]
  public static extern string VectorString_getitemcopy(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_getitem")]
  public static extern string VectorString_getitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_setitem")]
  public static extern void VectorString_setitem(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_AddRange")]
  public static extern void VectorString_AddRange(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_GetRange")]
  public static extern global::System.IntPtr VectorString_GetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_Insert")]
  public static extern void VectorString_Insert(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, string jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_InsertRange")]
  public static extern void VectorString_InsertRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_RemoveAt")]
  public static extern void VectorString_RemoveAt(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_RemoveRange")]
  public static extern void VectorString_RemoveRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_Repeat")]
  public static extern global::System.IntPtr VectorString_Repeat(string jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_Reverse__SWIG_0")]
  public static extern void VectorString_Reverse__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_Reverse__SWIG_1")]
  public static extern void VectorString_Reverse__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_SetRange")]
  public static extern void VectorString_SetRange(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2, global::System.Runtime.InteropServices.HandleRef jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_Contains")]
  public static extern bool VectorString_Contains(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_IndexOf")]
  public static extern int VectorString_IndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_LastIndexOf")]
  public static extern int VectorString_LastIndexOf(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_VectorString_Remove")]
  public static extern bool VectorString_Remove(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_delete_VectorString")]
  public static extern void delete_VectorString(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_delete_Match")]
  public static extern void delete_Match(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getValues__SWIG_0")]
  public static extern global::System.IntPtr Match_getValues__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getValues__SWIG_1")]
  public static extern global::System.IntPtr Match_getValues__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getValues__SWIG_2")]
  public static extern global::System.IntPtr Match_getValues__SWIG_2(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getValue__SWIG_0")]
  public static extern string Match_getValue__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getValue__SWIG_1")]
  public static extern string Match_getValue__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getValue__SWIG_2")]
  public static extern string Match_getValue__SWIG_2(global::System.Runtime.InteropServices.HandleRef jarg1, int jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getDeviceId")]
  public static extern string Match_getDeviceId(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getRank")]
  public static extern int Match_getRank(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getDifference")]
  public static extern int Match_getDifference(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getMethod")]
  public static extern int Match_getMethod(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Match_getUserAgent")]
  public static extern string Match_getUserAgent(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_Provider__SWIG_0")]
  public static extern global::System.IntPtr new_Provider__SWIG_0(string jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_Provider__SWIG_1")]
  public static extern global::System.IntPtr new_Provider__SWIG_1(string jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_Provider__SWIG_2")]
  public static extern global::System.IntPtr new_Provider__SWIG_2(string jarg1, string jarg2, int jarg3, int jarg4);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_Provider__SWIG_3")]
  public static extern global::System.IntPtr new_Provider__SWIG_3(string jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_Provider__SWIG_4")]
  public static extern global::System.IntPtr new_Provider__SWIG_4(string jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, int jarg3, int jarg4);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_new_Provider__SWIG_5")]
  public static extern global::System.IntPtr new_Provider__SWIG_5(string jarg1, int jarg2, int jarg3);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_delete_Provider")]
  public static extern void delete_Provider(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getHttpHeaders")]
  public static extern global::System.IntPtr Provider_getHttpHeaders(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getAvailableProperties")]
  public static extern global::System.IntPtr Provider_getAvailableProperties(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getDataSetName")]
  public static extern string Provider_getDataSetName(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getDataSetFormat")]
  public static extern string Provider_getDataSetFormat(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getDataSetPublishedDate")]
  public static extern string Provider_getDataSetPublishedDate(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getDataSetNextUpdateDate")]
  public static extern string Provider_getDataSetNextUpdateDate(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getDataSetSignatureCount")]
  public static extern int Provider_getDataSetSignatureCount(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getDataSetDeviceCombinations")]
  public static extern int Provider_getDataSetDeviceCombinations(global::System.Runtime.InteropServices.HandleRef jarg1);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getMatch__SWIG_0")]
  public static extern global::System.IntPtr Provider_getMatch__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getMatch__SWIG_1")]
  public static extern global::System.IntPtr Provider_getMatch__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getMatchJson__SWIG_0")]
  public static extern string Provider_getMatchJson__SWIG_0(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getMatchJson__SWIG_1")]
  public static extern string Provider_getMatchJson__SWIG_1(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getMatchForDeviceId")]
  public static extern global::System.IntPtr Provider_getMatchForDeviceId(global::System.Runtime.InteropServices.HandleRef jarg1, string jarg2);

  [global::System.Runtime.InteropServices.DllImport("FiftyOne.Mobile.Detection.Provider.Pattern.dll", EntryPoint="CSharp_Provider_getMatchForDeviceIds")]
  public static extern global::System.IntPtr Provider_getMatchForDeviceIds(global::System.Runtime.InteropServices.HandleRef jarg1, global::System.Runtime.InteropServices.HandleRef jarg2, int jarg3);
}

}
