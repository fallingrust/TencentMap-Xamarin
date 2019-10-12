using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentLocationManager", DoNotGenerateAcw=true)]
	public sealed partial class TencentLocationManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/field[@name='COORDINATE_TYPE_GCJ02']"
		[Register ("COORDINATE_TYPE_GCJ02")]
		public const int CoordinateTypeGcj02 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/field[@name='COORDINATE_TYPE_WGS84']"
		[Register ("COORDINATE_TYPE_WGS84")]
		public const int CoordinateTypeWgs84 = (int) 0;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/TencentLocationManager", typeof (TencentLocationManager));
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

		internal TencentLocationManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string Build {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='getBuild' and count(parameter)=0]"
			[Register ("getBuild", "()Ljava/lang/String;", "GetGetBuildHandler")]
			get {
				const string __id = "getBuild.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int CoordinateType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='getCoordinateType' and count(parameter)=0]"
			[Register ("getCoordinateType", "()I", "GetGetCoordinateTypeHandler")]
			get {
				const string __id = "getCoordinateType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='setCoordinateType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCoordinateType", "(I)V", "GetSetCoordinateType_IHandler")]
			set {
				const string __id = "setCoordinateType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public unsafe global::Com.Tencent.Map.Geolocation.ITencentLocation LastKnownLocation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='getLastKnownLocation' and count(parameter)=0]"
			[Register ("getLastKnownLocation", "()Lcom/tencent/map/geolocation/TencentLocation;", "GetGetLastKnownLocationHandler")]
			get {
				const string __id = "getLastKnownLocation.()Lcom/tencent/map/geolocation/TencentLocation;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.ITencentLocation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler")]
			get {
				const string __id = "getVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='disableForegroundLocation' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("disableForegroundLocation", "(Z)V", "")]
		public unsafe void DisableForegroundLocation (bool p0)
		{
			const string __id = "disableForegroundLocation.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='enableForegroundLocation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.app.Notification']]"
		[Register ("enableForegroundLocation", "(ILandroid/app/Notification;)V", "")]
		public unsafe void EnableForegroundLocation (int p0, global::Android.App.Notification p1)
		{
			const string __id = "enableForegroundLocation.(ILandroid/app/Notification;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getInstance", "(Landroid/content/Context;)Lcom/tencent/map/geolocation/TencentLocationManager;", "")]
		public static unsafe global::Com.Tencent.Map.Geolocation.TencentLocationManager GetInstance (global::Android.Content.Context p0)
		{
			const string __id = "getInstance.(Landroid/content/Context;)Lcom/tencent/map/geolocation/TencentLocationManager;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentLocationManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='removeUpdates' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentLocationListener']]"
		[Register ("removeUpdates", "(Lcom/tencent/map/geolocation/TencentLocationListener;)V", "")]
		public unsafe void RemoveUpdates (global::Com.Tencent.Map.Geolocation.ITencentLocationListener p0)
		{
			const string __id = "removeUpdates.(Lcom/tencent/map/geolocation/TencentLocationListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='requestLocationUpdates' and count(parameter)=2 and parameter[1][@type='com.tencent.map.geolocation.TencentLocationRequest'] and parameter[2][@type='com.tencent.map.geolocation.TencentLocationListener']]"
		[Register ("requestLocationUpdates", "(Lcom/tencent/map/geolocation/TencentLocationRequest;Lcom/tencent/map/geolocation/TencentLocationListener;)I", "")]
		public unsafe int RequestLocationUpdates (global::Com.Tencent.Map.Geolocation.TencentLocationRequest p0, global::Com.Tencent.Map.Geolocation.ITencentLocationListener p1)
		{
			const string __id = "requestLocationUpdates.(Lcom/tencent/map/geolocation/TencentLocationRequest;Lcom/tencent/map/geolocation/TencentLocationListener;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='requestLocationUpdates' and count(parameter)=3 and parameter[1][@type='com.tencent.map.geolocation.TencentLocationRequest'] and parameter[2][@type='com.tencent.map.geolocation.TencentLocationListener'] and parameter[3][@type='android.os.Looper']]"
		[Register ("requestLocationUpdates", "(Lcom/tencent/map/geolocation/TencentLocationRequest;Lcom/tencent/map/geolocation/TencentLocationListener;Landroid/os/Looper;)I", "")]
		public unsafe int RequestLocationUpdates (global::Com.Tencent.Map.Geolocation.TencentLocationRequest p0, global::Com.Tencent.Map.Geolocation.ITencentLocationListener p1, global::Android.OS.Looper p2)
		{
			const string __id = "requestLocationUpdates.(Lcom/tencent/map/geolocation/TencentLocationRequest;Lcom/tencent/map/geolocation/TencentLocationListener;Landroid/os/Looper;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='requestSingleFreshLocation' and count(parameter)=3 and parameter[1][@type='com.tencent.map.geolocation.TencentLocationRequest'] and parameter[2][@type='com.tencent.map.geolocation.TencentLocationListener'] and parameter[3][@type='android.os.Looper']]"
		[Register ("requestSingleFreshLocation", "(Lcom/tencent/map/geolocation/TencentLocationRequest;Lcom/tencent/map/geolocation/TencentLocationListener;Landroid/os/Looper;)I", "")]
		public unsafe int RequestSingleFreshLocation (global::Com.Tencent.Map.Geolocation.TencentLocationRequest p0, global::Com.Tencent.Map.Geolocation.ITencentLocationListener p1, global::Android.OS.Looper p2)
		{
			const string __id = "requestSingleFreshLocation.(Lcom/tencent/map/geolocation/TencentLocationRequest;Lcom/tencent/map/geolocation/TencentLocationListener;Landroid/os/Looper;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='setDebuggable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDebuggable", "(Z)V", "")]
		public unsafe void SetDebuggable (bool p0)
		{
			const string __id = "setDebuggable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='startIndoorLocation' and count(parameter)=0]"
		[Register ("startIndoorLocation", "()Z", "")]
		public unsafe bool StartIndoorLocation ()
		{
			const string __id = "startIndoorLocation.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='stopIndoorLocation' and count(parameter)=0]"
		[Register ("stopIndoorLocation", "()Z", "")]
		public unsafe bool StopIndoorLocation ()
		{
			const string __id = "stopIndoorLocation.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentLocationManager']/method[@name='triggerCodeGuarder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("triggerCodeGuarder", "(Z)V", "")]
		public unsafe void TriggerCodeGuarder (bool p0)
		{
			const string __id = "triggerCodeGuarder.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
