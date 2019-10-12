using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/util/Files", DoNotGenerateAcw=true)]
	public partial class Files : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/util/Files", typeof (Files));
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

		protected Files (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/constructor[@name='Files' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Files ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/method[@name='append' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.File']]"
		[Register ("append", "([BLjava/io/File;)V", "")]
		public static unsafe void Append (byte[] p0, global::Java.IO.File p1)
		{
			const string __id = "append.([BLjava/io/File;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/method[@name='append' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.io.File'] and parameter[3][@type='java.nio.charset.Charset']]"
		[Register ("append", "(Ljava/lang/CharSequence;Ljava/io/File;Ljava/nio/charset/Charset;)V", "")]
		public static unsafe void Append (global::Java.Lang.ICharSequence p0, global::Java.IO.File p1, global::Java.Nio.Charset.Charset p2)
		{
			const string __id = "append.(Ljava/lang/CharSequence;Ljava/io/File;Ljava/nio/charset/Charset;)V";
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static void Append (string p0, global::Java.IO.File p1, global::Java.Nio.Charset.Charset p2)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			Append (jls_p0, p1, p2);
			jls_p0?.Dispose ();
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/method[@name='fun_fe7b2b264010df956d4b71eefd61ddcd' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("fun_fe7b2b264010df956d4b71eefd61ddcd", "(Landroid/content/Context;)[B", "")]
		public static unsafe byte[] Fun_fe7b2b264010df956d4b71eefd61ddcd (global::Android.Content.Context p0)
		{
			const string __id = "fun_fe7b2b264010df956d4b71eefd61ddcd.(Landroid/content/Context;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/method[@name='readLines' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("readLines", "(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<string> ReadLines (global::Java.IO.File p0, global::Java.Nio.Charset.Charset p1)
		{
			const string __id = "readLines.(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/method[@name='toByteArray' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("toByteArray", "(Ljava/io/File;)[B", "")]
		public static unsafe byte[] ToByteArray (global::Java.IO.File p0)
		{
			const string __id = "toByteArray.(Ljava/io/File;)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/method[@name='toString' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.nio.charset.Charset']]"
		[Register ("toString", "(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.IO.File p0, global::Java.Nio.Charset.Charset p1)
		{
			const string __id = "toString.(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/method[@name='write' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.io.File']]"
		[Register ("write", "([BLjava/io/File;)V", "")]
		public static unsafe void Write (byte[] p0, global::Java.IO.File p1)
		{
			const string __id = "write.([BLjava/io/File;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation.util']/class[@name='Files']/method[@name='write' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.io.File'] and parameter[3][@type='java.nio.charset.Charset']]"
		[Register ("write", "(Ljava/lang/CharSequence;Ljava/io/File;Ljava/nio/charset/Charset;)V", "")]
		public static unsafe void Write (global::Java.Lang.ICharSequence p0, global::Java.IO.File p1, global::Java.Nio.Charset.Charset p2)
		{
			const string __id = "write.(Ljava/lang/CharSequence;Ljava/io/File;Ljava/nio/charset/Charset;)V";
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static void Write (string p0, global::Java.IO.File p1, global::Java.Nio.Charset.Charset p2)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			Write (jls_p0, p1, p2);
			jls_p0?.Dispose ();
		}

	}
}
