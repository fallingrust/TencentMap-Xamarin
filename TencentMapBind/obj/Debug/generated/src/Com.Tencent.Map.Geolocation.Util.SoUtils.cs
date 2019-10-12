using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/util/SoUtils", DoNotGenerateAcw=true)]
	public partial class SoUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/util/SoUtils", typeof (SoUtils));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected SoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']/constructor[@name='SoUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SoUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']/method[@name='fun_b' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='double[]']]"
		[Register ("fun_b", "(II[D)V", "")]
		public static unsafe void Fun_b (int p0, int p1, double[] p2)
		{
			const string __id = "fun_b.(II[D)V";
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']/method[@name='fun_d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fun_d", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Fun_d (string p0)
		{
			const string __id = "fun_d.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']/method[@name='fun_o' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("fun_o", "([BI)I", "")]
		public static unsafe int Fun_o (byte[] p0, int p1)
		{
			const string __id = "fun_o.([BI)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']/method[@name='fun_r' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("fun_r", "(DII)D", "")]
		public static unsafe double Fun_r (double p0, int p1, int p2)
		{
			const string __id = "fun_r.(DII)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']/method[@name='fun_v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fun_v", "(Ljava/lang/String;)I", "")]
		public static unsafe int Fun_v (string p0)
		{
			const string __id = "fun_v.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']/method[@name='fun_w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("fun_w", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int Fun_w (string p0, string p1)
		{
			const string __id = "fun_w.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='SoUtils']/method[@name='fun_x' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("fun_x", "(Z)V", "")]
		public static unsafe void Fun_x (bool p0)
		{
			const string __id = "fun_x.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
