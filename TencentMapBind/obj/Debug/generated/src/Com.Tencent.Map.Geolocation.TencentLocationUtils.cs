using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationUtils']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentLocationUtils", DoNotGenerateAcw=true)]
	public sealed partial class TencentLocationUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/TencentLocationUtils", typeof (TencentLocationUtils));
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

		internal TencentLocationUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationUtils']/method[@name='contains' and count(parameter)=3 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation'] and parameter[2][@type='double'] and parameter[3][@type='com.tencent.map.geolocation.TencentLocation']]"
		[Register ("contains", "(Lcom/tencent/map/geolocation/TencentLocation;DLcom/tencent/map/geolocation/TencentLocation;)Z", "")]
		public static unsafe bool Contains (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, double p1, global::Com.Tencent.Map.Geolocation.ITencentLocation p2)
		{
			const string __id = "contains.(Lcom/tencent/map/geolocation/TencentLocation;DLcom/tencent/map/geolocation/TencentLocation;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationUtils']/method[@name='distanceBetween' and count(parameter)=2 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation'] and parameter[2][@type='com.tencent.map.geolocation.TencentLocation']]"
		[Register ("distanceBetween", "(Lcom/tencent/map/geolocation/TencentLocation;Lcom/tencent/map/geolocation/TencentLocation;)D", "")]
		public static unsafe double DistanceBetween (global::Com.Tencent.Map.Geolocation.ITencentLocation p0, global::Com.Tencent.Map.Geolocation.ITencentLocation p1)
		{
			const string __id = "distanceBetween.(Lcom/tencent/map/geolocation/TencentLocation;Lcom/tencent/map/geolocation/TencentLocation;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationUtils']/method[@name='distanceBetween' and count(parameter)=4 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='double'] and parameter[4][@type='double']]"
		[Register ("distanceBetween", "(DDDD)D", "")]
		public static unsafe double DistanceBetween (double p0, double p1, double p2, double p3)
		{
			const string __id = "distanceBetween.(DDDD)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationUtils']/method[@name='isFromGps' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation']]"
		[Register ("isFromGps", "(Lcom/tencent/map/geolocation/TencentLocation;)Z", "")]
		public static unsafe bool IsFromGps (global::Com.Tencent.Map.Geolocation.ITencentLocation p0)
		{
			const string __id = "isFromGps.(Lcom/tencent/map/geolocation/TencentLocation;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationUtils']/method[@name='isFromNetwork' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocation']]"
		[Register ("isFromNetwork", "(Lcom/tencent/map/geolocation/TencentLocation;)Z", "")]
		public static unsafe bool IsFromNetwork (global::Com.Tencent.Map.Geolocation.ITencentLocation p0)
		{
			const string __id = "isFromNetwork.(Lcom/tencent/map/geolocation/TencentLocation;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationUtils']/method[@name='isSupportGps' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isSupportGps", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsSupportGps (global::Android.Content.Context p0)
		{
			const string __id = "isSupportGps.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationUtils']/method[@name='wgs84ToGcj02' and count(parameter)=2 and parameter[1][@type='double[]'] and parameter[2][@type='double[]']]"
		[Register ("wgs84ToGcj02", "([D[D)Z", "")]
		public static unsafe bool Wgs84ToGcj02 (double[] p0, double[] p1)
		{
			const string __id = "wgs84ToGcj02.([D[D)Z";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

	}
}
