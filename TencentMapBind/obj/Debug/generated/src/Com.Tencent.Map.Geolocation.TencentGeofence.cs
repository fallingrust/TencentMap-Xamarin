using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentGeofence", DoNotGenerateAcw=true)]
	public sealed partial class TencentGeofence : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence.Builder']"
		[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentGeofence$Builder", DoNotGenerateAcw=true)]
		public partial class Builder : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/TencentGeofence$Builder", typeof (Builder));
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

			protected Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence.Builder']/constructor[@name='TencentGeofence.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder ()
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

			static Delegate cb_build;
#pragma warning disable 0169
			static Delegate GetBuildHandler ()
			{
				if (cb_build == null)
					cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
				return cb_build;
			}

			static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Build ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/tencent/map/geolocation/TencentGeofence;", "GetBuildHandler")]
			public virtual unsafe global::Com.Tencent.Map.Geolocation.TencentGeofence Build ()
			{
				const string __id = "build.()Lcom/tencent/map/geolocation/TencentGeofence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentGeofence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setCircularRegion_DDF;
#pragma warning disable 0169
			static Delegate GetSetCircularRegion_DDFHandler ()
			{
				if (cb_setCircularRegion_DDF == null)
					cb_setCircularRegion_DDF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, float, IntPtr>) n_SetCircularRegion_DDF);
				return cb_setCircularRegion_DDF;
			}

			static IntPtr n_SetCircularRegion_DDF (IntPtr jnienv, IntPtr native__this, double p0, double p1, float p2)
			{
				global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetCircularRegion (p0, p1, p2));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence.Builder']/method[@name='setCircularRegion' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='double'] and parameter[3][@type='float']]"
			[Register ("setCircularRegion", "(DDF)Lcom/tencent/map/geolocation/TencentGeofence$Builder;", "GetSetCircularRegion_DDFHandler")]
			public virtual unsafe global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder SetCircularRegion (double p0, double p1, float p2)
			{
				const string __id = "setCircularRegion.(DDF)Lcom/tencent/map/geolocation/TencentGeofence$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue (p2);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setExpirationDuration_J;
#pragma warning disable 0169
			static Delegate GetSetExpirationDuration_JHandler ()
			{
				if (cb_setExpirationDuration_J == null)
					cb_setExpirationDuration_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_SetExpirationDuration_J);
				return cb_setExpirationDuration_J;
			}

			static IntPtr n_SetExpirationDuration_J (IntPtr jnienv, IntPtr native__this, long p0)
			{
				global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.SetExpirationDuration (p0));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence.Builder']/method[@name='setExpirationDuration' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setExpirationDuration", "(J)Lcom/tencent/map/geolocation/TencentGeofence$Builder;", "GetSetExpirationDuration_JHandler")]
			public virtual unsafe global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder SetExpirationDuration (long p0)
			{
				const string __id = "setExpirationDuration.(J)Lcom/tencent/map/geolocation/TencentGeofence$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_setTag_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetSetTag_Ljava_lang_String_Handler ()
			{
				if (cb_setTag_Ljava_lang_String_ == null)
					cb_setTag_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_String_);
				return cb_setTag_Ljava_lang_String_;
			}

			static IntPtr n_SetTag_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTag (p0));
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence.Builder']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTag", "(Ljava/lang/String;)Lcom/tencent/map/geolocation/TencentGeofence$Builder;", "GetSetTag_Ljava_lang_String_Handler")]
			public virtual unsafe global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder SetTag (string p0)
			{
				const string __id = "setTag.(Ljava/lang/String;)Lcom/tencent/map/geolocation/TencentGeofence$Builder;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Map.Geolocation.TencentGeofence.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/TencentGeofence", typeof (TencentGeofence));
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

		internal TencentGeofence (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				const string __id = "getDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe long ExpireAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='getExpireAt' and count(parameter)=0]"
			[Register ("getExpireAt", "()J", "GetGetExpireAtHandler")]
			get {
				const string __id = "getExpireAt.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "GetGetLatitudeHandler")]
			get {
				const string __id = "getLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "GetGetLongitudeHandler")]
			get {
				const string __id = "getLongitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
			get {
				const string __id = "getTag.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			const string __id = "equals.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			const string __id = "hashCode.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofence']/method[@name='toString' and count(parameter)=0]"
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
