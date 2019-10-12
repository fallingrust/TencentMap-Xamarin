using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentLocationRequest", DoNotGenerateAcw=true)]
	public sealed partial class TencentLocationRequest : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/field[@name='REQUEST_LEVEL_ADMIN_AREA']"
		[Register ("REQUEST_LEVEL_ADMIN_AREA")]
		public const int RequestLevelAdminArea = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/field[@name='REQUEST_LEVEL_GEO']"
		[Register ("REQUEST_LEVEL_GEO")]
		public const int RequestLevelGeo = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/field[@name='REQUEST_LEVEL_NAME']"
		[Register ("REQUEST_LEVEL_NAME")]
		public const int RequestLevelName = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/field[@name='REQUEST_LEVEL_POI']"
		[Register ("REQUEST_LEVEL_POI")]
		public const int RequestLevelPoi = (int) 4;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/TencentLocationRequest", typeof (TencentLocationRequest));
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

		internal TencentLocationRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/constructor[@name='TencentLocationRequest' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocationRequest']]"
		[Register (".ctor", "(Lcom/tencent/map/geolocation/TencentLocationRequest;)V", "")]
		public unsafe TencentLocationRequest (global::Com.Tencent.Map.Geolocation.TencentLocationRequest p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/tencent/map/geolocation/TencentLocationRequest;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Android.OS.Bundle Extras {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='getExtras' and count(parameter)=0]"
			[Register ("getExtras", "()Landroid/os/Bundle;", "GetGetExtrasHandler")]
			get {
				const string __id = "getExtras.()Landroid/os/Bundle;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe long Interval {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='getInterval' and count(parameter)=0]"
			[Register ("getInterval", "()J", "GetGetIntervalHandler")]
			get {
				const string __id = "getInterval.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsAllowCache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='isAllowCache' and count(parameter)=0]"
			[Register ("isAllowCache", "()Z", "GetIsAllowCacheHandler")]
			get {
				const string __id = "isAllowCache.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsAllowDirection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='isAllowDirection' and count(parameter)=0]"
			[Register ("isAllowDirection", "()Z", "GetIsAllowDirectionHandler")]
			get {
				const string __id = "isAllowDirection.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsAllowGPS {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='isAllowGPS' and count(parameter)=0]"
			[Register ("isAllowGPS", "()Z", "GetIsAllowGPSHandler")]
			get {
				const string __id = "isAllowGPS.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsIndoorLocationMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='isIndoorLocationMode' and count(parameter)=0]"
			[Register ("isIndoorLocationMode", "()Z", "GetIsIndoorLocationModeHandler")]
			get {
				const string __id = "isIndoorLocationMode.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string PhoneNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='getPhoneNumber' and count(parameter)=0]"
			[Register ("getPhoneNumber", "()Ljava/lang/String;", "GetGetPhoneNumberHandler")]
			get {
				const string __id = "getPhoneNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string QQ {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='getQQ' and count(parameter)=0]"
			[Register ("getQQ", "()Ljava/lang/String;", "GetGetQQHandler")]
			get {
				const string __id = "getQQ.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int RequestLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='getRequestLevel' and count(parameter)=0]"
			[Register ("getRequestLevel", "()I", "GetGetRequestLevelHandler")]
			get {
				const string __id = "getRequestLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string SmallAppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='getSmallAppKey' and count(parameter)=0]"
			[Register ("getSmallAppKey", "()Ljava/lang/String;", "GetGetSmallAppKeyHandler")]
			get {
				const string __id = "getSmallAppKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='copy' and count(parameter)=2 and parameter[1][@type='com.tencent.map.geolocation.TencentLocationRequest'] and parameter[2][@type='com.tencent.map.geolocation.TencentLocationRequest']]"
		[Register ("copy", "(Lcom/tencent/map/geolocation/TencentLocationRequest;Lcom/tencent/map/geolocation/TencentLocationRequest;)V", "")]
		public static unsafe void Copy (global::Com.Tencent.Map.Geolocation.TencentLocationRequest p0, global::Com.Tencent.Map.Geolocation.TencentLocationRequest p1)
		{
			const string __id = "copy.(Lcom/tencent/map/geolocation/TencentLocationRequest;Lcom/tencent/map/geolocation/TencentLocationRequest;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public static unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest Create ()
		{
			const string __id = "create.()Lcom/tencent/map/geolocation/TencentLocationRequest;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setAllowCache' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowCache", "(Z)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetAllowCache (bool p0)
		{
			const string __id = "setAllowCache.(Z)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setAllowDirection' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowDirection", "(Z)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetAllowDirection (bool p0)
		{
			const string __id = "setAllowDirection.(Z)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setAllowGPS' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowGPS", "(Z)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetAllowGPS (bool p0)
		{
			const string __id = "setAllowGPS.(Z)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setIndoorLocationMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIndoorLocationMode", "(Z)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetIndoorLocationMode (bool p0)
		{
			const string __id = "setIndoorLocationMode.(Z)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setInterval' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setInterval", "(J)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetInterval (long p0)
		{
			const string __id = "setInterval.(J)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setPhoneNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPhoneNumber", "(Ljava/lang/String;)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetPhoneNumber (string p0)
		{
			const string __id = "setPhoneNumber.(Ljava/lang/String;)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setQQ' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setQQ", "(Ljava/lang/String;)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetQQ (string p0)
		{
			const string __id = "setQQ.(Ljava/lang/String;)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setRequestLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRequestLevel", "(I)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetRequestLevel (int p0)
		{
			const string __id = "setRequestLevel.(I)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='setSmallAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setSmallAppKey", "(Ljava/lang/String;)Lcom/tencent/map/geolocation/TencentLocationRequest;", "")]
		public unsafe global::Com.Tencent.Map.Geolocation.TencentLocationRequest SetSmallAppKey (string p0)
		{
			const string __id = "setSmallAppKey.(Ljava/lang/String;)Lcom/tencent/map/geolocation/TencentLocationRequest;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationRequest']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
