using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapController", DoNotGenerateAcw=true)]
	public partial class MapController : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/MapController", typeof (MapController));
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

		protected MapController (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/constructor[@name='MapController' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register (".ctor", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "")]
		public unsafe MapController (global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V";

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

		static Delegate cb_isAnimateEable;
#pragma warning disable 0169
		static Delegate GetIsAnimateEableHandler ()
		{
			if (cb_isAnimateEable == null)
				cb_isAnimateEable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimateEable);
			return cb_isAnimateEable;
		}

		static bool n_IsAnimateEable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnimateEable;
		}
#pragma warning restore 0169

		static Delegate cb_setAnimateEable_Z;
#pragma warning disable 0169
		static Delegate GetSetAnimateEable_ZHandler ()
		{
			if (cb_setAnimateEable_Z == null)
				cb_setAnimateEable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAnimateEable_Z);
			return cb_setAnimateEable_Z;
		}

		static void n_SetAnimateEable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateEable = p0;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool AnimateEable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='isAnimateEable' and count(parameter)=0]"
			[Register ("isAnimateEable", "()Z", "GetIsAnimateEableHandler")]
			get {
				const string __id = "isAnimateEable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setAnimateEable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAnimateEable", "(Z)V", "GetSetAnimateEable_ZHandler")]
			set {
				const string __id = "setAnimateEable.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProjection;
#pragma warning disable 0169
		static Delegate GetGetProjectionHandler ()
		{
			if (cb_getProjection == null)
				cb_getProjection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProjection);
			return cb_getProjection;
		}

		static IntPtr n_GetProjection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Projection);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Lcom/tencent/tencentmap/mapsdk/map/Projection;", "GetGetProjectionHandler")]
			get {
				const string __id = "getProjection.()Lcom/tencent/tencentmap/mapsdk/map/Projection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler ()
		{
			if (cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == null)
				cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_);
			return cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		}

		static void n_AnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='animateTo' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint']]"
		[Obsolete (@"deprecated")]
		[Register ("animateTo", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V", "GetAnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler")]
		public virtual unsafe void AnimateTo (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0)
		{
			const string __id = "animateTo.(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_Runnable_Handler ()
		{
			if (cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_Runnable_ == null)
				cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_Runnable_);
			return cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_Runnable_;
		}

		static void n_AnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable p1 = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='animateTo' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='java.lang.Runnable']]"
		[Obsolete (@"deprecated")]
		[Register ("animateTo", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Ljava/lang/Runnable;)V", "GetAnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void AnimateTo (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Java.Lang.IRunnable p1)
		{
			const string __id = "animateTo.(Lcom/tencent/mapsdk/raster/model/GeoPoint;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler ()
		{
			if (cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ == null)
				cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_AnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_);
			return cb_animateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
		}

		static void n_AnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p2 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='animateTo' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='long'] and parameter[3][@type='com.tencent.tencentmap.mapsdk.map.CancelableCallback']]"
		[Obsolete (@"deprecated")]
		[Register ("animateTo", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;JLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V", "GetAnimateTo_Lcom_tencent_mapsdk_raster_model_GeoPoint_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler")]
		public virtual unsafe void AnimateTo (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, long p1, global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p2)
		{
			const string __id = "animateTo.(Lcom/tencent/mapsdk/raster/model/GeoPoint;JLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
#pragma warning disable 0169
		static Delegate GetAnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler ()
		{
			if (cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ == null)
				cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, long, IntPtr>) n_AnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_);
			return cb_animateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
		}

		static void n_AnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p2 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.AnimateTo (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='animateTo' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='long'] and parameter[3][@type='com.tencent.tencentmap.mapsdk.map.CancelableCallback']]"
		[Obsolete (@"deprecated")]
		[Register ("animateTo", "(Lcom/tencent/mapsdk/raster/model/LatLng;JLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V", "GetAnimateTo_Lcom_tencent_mapsdk_raster_model_LatLng_JLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler")]
		public virtual unsafe void AnimateTo (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, long p1, global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p2)
		{
			const string __id = "animateTo.(Lcom/tencent/mapsdk/raster/model/LatLng;JLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_;
#pragma warning disable 0169
		static Delegate GetGetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Handler ()
		{
			if (cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_ == null)
				cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_);
			return cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_;
		}

		static void n_GetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetScreenShot (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='getScreenShot' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnScreenShotListener']]"
		[Obsolete (@"deprecated")]
		[Register ("getScreenShot", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;)V", "GetGetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Handler")]
		public virtual unsafe void GetScreenShot (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener p0)
		{
			const string __id = "getScreenShot.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_;
#pragma warning disable 0169
		static Delegate GetGetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_Handler ()
		{
			if (cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_ == null)
				cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_);
			return cb_getScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_;
		}

		static void n_GetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Rect p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Rect> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GetScreenShot (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='getScreenShot' and count(parameter)=2 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnScreenShotListener'] and parameter[2][@type='android.graphics.Rect']]"
		[Obsolete (@"deprecated")]
		[Register ("getScreenShot", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;Landroid/graphics/Rect;)V", "GetGetScreenShot_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnScreenShotListener_Landroid_graphics_Rect_Handler")]
		public virtual unsafe void GetScreenShot (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnScreenShotListener p0, global::Android.Graphics.Rect p1)
		{
			const string __id = "getScreenShot.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnScreenShotListener;Landroid/graphics/Rect;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrollBy_FF;
#pragma warning disable 0169
		static Delegate GetScrollBy_FFHandler ()
		{
			if (cb_scrollBy_FF == null)
				cb_scrollBy_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_ScrollBy_FF);
			return cb_scrollBy_FF;
		}

		static void n_ScrollBy_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBy (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='scrollBy' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Obsolete (@"deprecated")]
		[Register ("scrollBy", "(FF)V", "GetScrollBy_FFHandler")]
		public virtual unsafe void ScrollBy (float p0, float p1)
		{
			const string __id = "scrollBy.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
#pragma warning disable 0169
		static Delegate GetScrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler ()
		{
			if (cb_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ == null)
				cb_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, long, IntPtr>) n_ScrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_);
			return cb_scrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_;
		}

		static void n_ScrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_ (IntPtr jnienv, IntPtr native__this, float p0, float p1, long p2, IntPtr native_p3)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p3 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.ScrollBy (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='scrollBy' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='long'] and parameter[4][@type='com.tencent.tencentmap.mapsdk.map.CancelableCallback']]"
		[Obsolete (@"deprecated")]
		[Register ("scrollBy", "(FFJLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V", "GetScrollBy_FFJLcom_tencent_tencentmap_mapsdk_map_CancelableCallback_Handler")]
		public virtual unsafe void ScrollBy (float p0, float p1, long p2, global::Com.Tencent.Tencentmap.Mapsdk.Map.ICancelableCallback p3)
		{
			const string __id = "scrollBy.(FFJLcom/tencent/tencentmap/mapsdk/map/CancelableCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCenter_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetSetCenter_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler ()
		{
			if (cb_setCenter_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == null)
				cb_setCenter_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_Lcom_tencent_mapsdk_raster_model_GeoPoint_);
			return cb_setCenter_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		}

		static void n_SetCenter_Lcom_tencent_mapsdk_raster_model_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint']]"
		[Obsolete (@"deprecated")]
		[Register ("setCenter", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V", "GetSetCenter_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler")]
		public virtual unsafe void SetCenter (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0)
		{
			const string __id = "setCenter.(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_;
#pragma warning disable 0169
		static Delegate GetSetInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_Handler ()
		{
			if (cb_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_ == null)
				cb_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_);
			return cb_setInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_;
		}

		static void n_SetInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetInfoWindowAdapter (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setInfoWindowAdapter' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.InfoWindowAdapter']]"
		[Obsolete (@"deprecated")]
		[Register ("setInfoWindowAdapter", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$InfoWindowAdapter;)V", "GetSetInfoWindowAdapter_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_InfoWindowAdapter_Handler")]
		public virtual unsafe void SetInfoWindowAdapter (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IInfoWindowAdapter p0)
		{
			const string __id = "setInfoWindowAdapter.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$InfoWindowAdapter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_Handler ()
		{
			if (cb_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_ == null)
				cb_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_);
			return cb_setOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_;
		}

		static void n_SetOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnInfoWindowClickListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnInfoWindowClickListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnInfoWindowClickListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnInfoWindowClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnInfoWindowClickListener;)V", "GetSetOnInfoWindowClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnInfoWindowClickListener_Handler")]
		public virtual unsafe void SetOnInfoWindowClickListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener p0)
		{
			const string __id = "setOnInfoWindowClickListener.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnInfoWindowClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_Handler ()
		{
			if (cb_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_ == null)
				cb_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_);
			return cb_setOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_;
		}

		static void n_SetOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapCameraChangeListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnMapCameraChangeListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapCameraChangeListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMapCameraChangeListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapCameraChangeListener;)V", "GetSetOnMapCameraChangeListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapCameraChangeListener_Handler")]
		public virtual unsafe void SetOnMapCameraChangeListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener p0)
		{
			const string __id = "setOnMapCameraChangeListener.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapCameraChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_Handler ()
		{
			if (cb_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_ == null)
				cb_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_);
			return cb_setOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_;
		}

		static void n_SetOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapClickListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnMapClickListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapClickListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMapClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapClickListener;)V", "GetSetOnMapClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapClickListener_Handler")]
		public virtual unsafe void SetOnMapClickListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener p0)
		{
			const string __id = "setOnMapClickListener.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapHitListener_Lcom_tencent_tencentmap_mapsdk_map_OnMapHitListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapHitListener_Lcom_tencent_tencentmap_mapsdk_map_OnMapHitListener_Handler ()
		{
			if (cb_setOnMapHitListener_Lcom_tencent_tencentmap_mapsdk_map_OnMapHitListener_ == null)
				cb_setOnMapHitListener_Lcom_tencent_tencentmap_mapsdk_map_OnMapHitListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapHitListener_Lcom_tencent_tencentmap_mapsdk_map_OnMapHitListener_);
			return cb_setOnMapHitListener_Lcom_tencent_tencentmap_mapsdk_map_OnMapHitListener_;
		}

		static void n_SetOnMapHitListener_Lcom_tencent_tencentmap_mapsdk_map_OnMapHitListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapHitListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnMapHitListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.OnMapHitListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMapHitListener", "(Lcom/tencent/tencentmap/mapsdk/map/OnMapHitListener;)V", "GetSetOnMapHitListener_Lcom_tencent_tencentmap_mapsdk_map_OnMapHitListener_Handler")]
		public virtual unsafe void SetOnMapHitListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener p0)
		{
			const string __id = "setOnMapHitListener.(Lcom/tencent/tencentmap/mapsdk/map/OnMapHitListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_Handler ()
		{
			if (cb_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_ == null)
				cb_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_);
			return cb_setOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_;
		}

		static void n_SetOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapLoadedListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnMapLoadedListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapLoadedListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMapLoadedListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLoadedListener;)V", "GetSetOnMapLoadedListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLoadedListener_Handler")]
		public virtual unsafe void SetOnMapLoadedListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener p0)
		{
			const string __id = "setOnMapLoadedListener.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLoadedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapLongClickLisener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapLongClickLisener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_Handler ()
		{
			if (cb_setOnMapLongClickLisener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_ == null)
				cb_setOnMapLongClickLisener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapLongClickLisener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_);
			return cb_setOnMapLongClickLisener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_;
		}

		static void n_SetOnMapLongClickLisener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapLongClickLisener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnMapLongClickLisener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMapLongClickListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMapLongClickLisener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLongClickListener;)V", "GetSetOnMapLongClickLisener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMapLongClickListener_Handler")]
		public virtual unsafe void SetOnMapLongClickLisener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener p0)
		{
			const string __id = "setOnMapLongClickLisener.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMapLongClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMapPressClickLisener_Lcom_tencent_tencentmap_mapsdk_map_OnMapLongPressListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMapPressClickLisener_Lcom_tencent_tencentmap_mapsdk_map_OnMapLongPressListener_Handler ()
		{
			if (cb_setOnMapPressClickLisener_Lcom_tencent_tencentmap_mapsdk_map_OnMapLongPressListener_ == null)
				cb_setOnMapPressClickLisener_Lcom_tencent_tencentmap_mapsdk_map_OnMapLongPressListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMapPressClickLisener_Lcom_tencent_tencentmap_mapsdk_map_OnMapLongPressListener_);
			return cb_setOnMapPressClickLisener_Lcom_tencent_tencentmap_mapsdk_map_OnMapLongPressListener_;
		}

		static void n_SetOnMapPressClickLisener_Lcom_tencent_tencentmap_mapsdk_map_OnMapLongPressListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMapPressClickLisener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnMapPressClickLisener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.OnMapLongPressListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMapPressClickLisener", "(Lcom/tencent/tencentmap/mapsdk/map/OnMapLongPressListener;)V", "GetSetOnMapPressClickLisener_Lcom_tencent_tencentmap_mapsdk_map_OnMapLongPressListener_Handler")]
		public virtual unsafe void SetOnMapPressClickLisener (global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener p0)
		{
			const string __id = "setOnMapPressClickLisener.(Lcom/tencent/tencentmap/mapsdk/map/OnMapLongPressListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_Handler ()
		{
			if (cb_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_ == null)
				cb_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_);
			return cb_setOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_;
		}

		static void n_SetOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMarkerClickListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnMarkerClickListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMarkerClickListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMarkerClickListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerClickListener;)V", "GetSetOnMarkerClickListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerClickListener_Handler")]
		public virtual unsafe void SetOnMarkerClickListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener p0)
		{
			const string __id = "setOnMarkerClickListener.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnMarkerDragListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnMarkerDragListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_Handler ()
		{
			if (cb_setOnMarkerDragListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_ == null)
				cb_setOnMarkerDragListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnMarkerDragListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_);
			return cb_setOnMarkerDragListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_;
		}

		static void n_SetOnMarkerDragListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener p0 = (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener)global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnMarkerDragListener (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setOnMarkerDragListener' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.TencentMap.OnMarkerDraggedListener']]"
		[Obsolete (@"deprecated")]
		[Register ("setOnMarkerDragListener", "(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerDraggedListener;)V", "GetSetOnMarkerDragListener_Lcom_tencent_tencentmap_mapsdk_map_TencentMap_OnMarkerDraggedListener_Handler")]
		public virtual unsafe void SetOnMarkerDragListener (global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener p0)
		{
			const string __id = "setOnMarkerDragListener.(Lcom/tencent/tencentmap/mapsdk/map/TencentMap$OnMarkerDraggedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setZoom_I;
#pragma warning disable 0169
		static Delegate GetSetZoom_IHandler ()
		{
			if (cb_setZoom_I == null)
				cb_setZoom_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoom_I);
			return cb_setZoom_I;
		}

		static void n_SetZoom_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setZoom", "(I)V", "GetSetZoom_IHandler")]
		public virtual unsafe void SetZoom (int p0)
		{
			const string __id = "setZoom.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopAnimation;
#pragma warning disable 0169
		static Delegate GetStopAnimationHandler ()
		{
			if (cb_stopAnimation == null)
				cb_stopAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAnimation);
			return cb_stopAnimation;
		}

		static void n_StopAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='stopAnimation' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("stopAnimation", "()V", "GetStopAnimationHandler")]
		public virtual unsafe void StopAnimation ()
		{
			const string __id = "stopAnimation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomIn);
			return cb_zoomIn;
		}

		static void n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='zoomIn' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("zoomIn", "()V", "GetZoomInHandler")]
		public virtual unsafe void ZoomIn ()
		{
			const string __id = "zoomIn.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_zoomInFixing_II;
#pragma warning disable 0169
		static Delegate GetZoomInFixing_IIHandler ()
		{
			if (cb_zoomInFixing_II == null)
				cb_zoomInFixing_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ZoomInFixing_II);
			return cb_zoomInFixing_II;
		}

		static void n_ZoomInFixing_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomInFixing (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='zoomInFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("zoomInFixing", "(II)V", "GetZoomInFixing_IIHandler")]
		public virtual unsafe void ZoomInFixing (int p0, int p1)
		{
			const string __id = "zoomInFixing.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomOut);
			return cb_zoomOut;
		}

		static void n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='zoomOut' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("zoomOut", "()V", "GetZoomOutHandler")]
		public virtual unsafe void ZoomOut ()
		{
			const string __id = "zoomOut.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_zoomOutFixing_II;
#pragma warning disable 0169
		static Delegate GetZoomOutFixing_IIHandler ()
		{
			if (cb_zoomOutFixing_II == null)
				cb_zoomOutFixing_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ZoomOutFixing_II);
			return cb_zoomOutFixing_II;
		}

		static void n_ZoomOutFixing_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOutFixing (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='zoomOutFixing' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("zoomOutFixing", "(II)V", "GetZoomOutFixing_IIHandler")]
		public virtual unsafe void ZoomOutFixing (int p0, int p1)
		{
			const string __id = "zoomOutFixing.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomToSpan_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetZoomToSpan_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler ()
		{
			if (cb_zoomToSpan_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == null)
				cb_zoomToSpan_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_ZoomToSpan_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_);
			return cb_zoomToSpan_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		}

		static void n_ZoomToSpan_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='zoomToSpan' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.mapsdk.raster.model.GeoPoint']]"
		[Obsolete (@"deprecated")]
		[Register ("zoomToSpan", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/mapsdk/raster/model/GeoPoint;)V", "GetZoomToSpan_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler")]
		public virtual unsafe void ZoomToSpan (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p1)
		{
			const string __id = "zoomToSpan.(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/mapsdk/raster/model/GeoPoint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomToSpan_II;
#pragma warning disable 0169
		static Delegate GetZoomToSpan_IIHandler ()
		{
			if (cb_zoomToSpan_II == null)
				cb_zoomToSpan_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_ZoomToSpan_II);
			return cb_zoomToSpan_II;
		}

		static void n_ZoomToSpan_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToSpan (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapController']/method[@name='zoomToSpan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("zoomToSpan", "(II)V", "GetZoomToSpan_IIHandler")]
		public virtual unsafe void ZoomToSpan (int p0, int p1)
		{
			const string __id = "zoomToSpan.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.InfoWindowClickEventArgs> InfoWindowClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor_SetOnInfoWindowClickListener,
						__CreateIOnInfoWindowClickListenerImplementor,
						SetOnInfoWindowClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor>(
						ref weak_implementor_SetOnInfoWindowClickListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor.__IsEmpty,
						__v => SetOnInfoWindowClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnInfoWindowClickListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor __CreateIOnInfoWindowClickListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnInfoWindowClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.CameraChangeEventArgs> CameraChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnMapCameraChangeListener,
						__CreateIOnMapCameraChangeListenerImplementor,
						SetOnMapCameraChangeListener,
						__h => __h.OnCameraChangeHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnMapCameraChangeListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapCameraChangeListener (null),
						__h => __h.OnCameraChangeHandler -= value);
			}
		}

		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.CameraChangeFinishEventArgs> CameraChangeFinish {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnMapCameraChangeListener,
						__CreateIOnMapCameraChangeListenerImplementor,
						SetOnMapCameraChangeListener,
						__h => __h.OnCameraChangeFinishHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor>(
						ref weak_implementor_SetOnMapCameraChangeListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor.__IsEmpty,
						__v => SetOnMapCameraChangeListener (null),
						__h => __h.OnCameraChangeFinishHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapCameraChangeListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor __CreateIOnMapCameraChangeListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapCameraChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MapClickEventArgs> MapClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						__CreateIOnMapClickListenerImplementor,
						SetOnMapClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor>(
						ref weak_implementor_SetOnMapClickListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor.__IsEmpty,
						__v => SetOnMapClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapClickListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor __CreateIOnMapClickListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapHitEventArgs> MapHit {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListenerImplementor>(
						ref weak_implementor_SetOnMapHitListener,
						__CreateIOnMapHitListenerImplementor,
						SetOnMapHitListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListenerImplementor>(
						ref weak_implementor_SetOnMapHitListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListenerImplementor.__IsEmpty,
						__v => SetOnMapHitListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapHitListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListenerImplementor __CreateIOnMapHitListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener"
		public event EventHandler MapLoaded {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor>(
						ref weak_implementor_SetOnMapLoadedListener,
						__CreateIOnMapLoadedListenerImplementor,
						SetOnMapLoadedListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor>(
						ref weak_implementor_SetOnMapLoadedListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor.__IsEmpty,
						__v => SetOnMapLoadedListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLoadedListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor __CreateIOnMapLoadedListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLoadedListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MapLongClickEventArgs> MapLongClickLisener {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickLisener,
						__CreateIOnMapLongClickListenerImplementor,
						SetOnMapLongClickLisener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor>(
						ref weak_implementor_SetOnMapLongClickLisener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor.__IsEmpty,
						__v => SetOnMapLongClickLisener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapLongClickLisener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor __CreateIOnMapLongClickListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMapLongClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapLongPressEventArgs> MapPressClickLisener {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListenerImplementor>(
						ref weak_implementor_SetOnMapPressClickLisener,
						__CreateIOnMapLongPressListenerImplementor,
						SetOnMapPressClickLisener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListenerImplementor>(
						ref weak_implementor_SetOnMapPressClickLisener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListenerImplementor.__IsEmpty,
						__v => SetOnMapPressClickLisener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMapPressClickLisener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListenerImplementor __CreateIOnMapLongPressListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapLongPressListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MarkerClickEventArgs> MarkerClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						__CreateIOnMarkerClickListenerImplementor,
						SetOnMarkerClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor>(
						ref weak_implementor_SetOnMarkerClickListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor.__IsEmpty,
						__v => SetOnMarkerClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerClickListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor __CreateIOnMarkerClickListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener"
		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MarkerDragEventArgs> MarkerDrag {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDraggedListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragHandler -= value);
			}
		}

		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MarkerDragEndEventArgs> MarkerDragEnd {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDraggedListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragEndHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragEndHandler -= value);
			}
		}

		public event EventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.MarkerDragStartEventArgs> MarkerDragStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						__CreateIOnMarkerDraggedListenerImplementor,
						SetOnMarkerDragListener,
						__h => __h.OnMarkerDragStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListener, global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor>(
						ref weak_implementor_SetOnMarkerDragListener,
						global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor.__IsEmpty,
						__v => SetOnMarkerDragListener (null),
						__h => __h.OnMarkerDragStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetOnMarkerDragListener;

		global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor __CreateIOnMarkerDraggedListenerImplementor ()
		{
			return new global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap.IOnMarkerDraggedListenerImplementor (this);
		}
#endregion
	}
}
