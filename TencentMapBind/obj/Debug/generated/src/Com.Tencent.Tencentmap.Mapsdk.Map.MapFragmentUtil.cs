using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapFragmentUtil", DoNotGenerateAcw=true)]
	public partial class MapFragmentUtil : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/MapFragmentUtil", typeof (MapFragmentUtil));
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

		protected MapFragmentUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getLatitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLatitudeSpanHandler ()
		{
			if (cb_getLatitudeSpan == null)
				cb_getLatitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLatitudeSpan);
			return cb_getLatitudeSpan;
		}

		static int n_GetLatitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='getLatitudeSpan' and count(parameter)=0]"
			[Register ("getLatitudeSpan", "()I", "GetGetLatitudeSpanHandler")]
			get {
				const string __id = "getLatitudeSpan.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLongitudeSpan;
#pragma warning disable 0169
		static Delegate GetGetLongitudeSpanHandler ()
		{
			if (cb_getLongitudeSpan == null)
				cb_getLongitudeSpan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLongitudeSpan);
			return cb_getLongitudeSpan;
		}

		static int n_GetLongitudeSpan (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='getLongitudeSpan' and count(parameter)=0]"
			[Register ("getLongitudeSpan", "()I", "GetGetLongitudeSpanHandler")]
			get {
				const string __id = "getLongitudeSpan.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMapCenter;
#pragma warning disable 0169
		static Delegate GetGetMapCenterHandler ()
		{
			if (cb_getMapCenter == null)
				cb_getMapCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapCenter);
			return cb_getMapCenter;
		}

		static IntPtr n_GetMapCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapCenter);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLng MapCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='getMapCenter' and count(parameter)=0]"
			[Register ("getMapCenter", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetMapCenterHandler")]
			get {
				const string __id = "getMapCenter.()Lcom/tencent/mapsdk/raster/model/LatLng;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMapController;
#pragma warning disable 0169
		static Delegate GetGetMapControllerHandler ()
		{
			if (cb_getMapController == null)
				cb_getMapController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMapController);
			return cb_getMapController;
		}

		static IntPtr n_GetMapController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapController);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController MapController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='getMapController' and count(parameter)=0]"
			[Register ("getMapController", "()Lcom/tencent/tencentmap/mapsdk/map/MapController;", "GetGetMapControllerHandler")]
			get {
				const string __id = "getMapController.()Lcom/tencent/tencentmap/mapsdk/map/MapController;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isSatellite;
#pragma warning disable 0169
		static Delegate GetIsSatelliteHandler ()
		{
			if (cb_isSatellite == null)
				cb_isSatellite = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSatellite);
			return cb_isSatellite;
		}

		static bool n_IsSatellite (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Satellite;
		}
#pragma warning restore 0169

		static Delegate cb_setSatellite_Z;
#pragma warning disable 0169
		static Delegate GetSetSatellite_ZHandler ()
		{
			if (cb_setSatellite_Z == null)
				cb_setSatellite_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSatellite_Z);
			return cb_setSatellite_Z;
		}

		static void n_SetSatellite_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Satellite = p0;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool Satellite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='isSatellite' and count(parameter)=0]"
			[Register ("isSatellite", "()Z", "GetIsSatelliteHandler")]
			get {
				const string __id = "isSatellite.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='setSatellite' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSatellite", "(Z)V", "GetSetSatellite_ZHandler")]
			set {
				const string __id = "setSatellite.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScalePerPixel;
#pragma warning disable 0169
		static Delegate GetGetScalePerPixelHandler ()
		{
			if (cb_getScalePerPixel == null)
				cb_getScalePerPixel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScalePerPixel);
			return cb_getScalePerPixel;
		}

		static float n_GetScalePerPixel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalePerPixel;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe float ScalePerPixel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='getScalePerPixel' and count(parameter)=0]"
			[Register ("getScalePerPixel", "()F", "GetGetScalePerPixelHandler")]
			get {
				const string __id = "getScalePerPixel.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetZoomLevelHandler ()
		{
			if (cb_getZoomLevel == null)
				cb_getZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetZoomLevel);
			return cb_getZoomLevel;
		}

		static int n_GetZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='getZoomLevel' and count(parameter)=0]"
			[Register ("getZoomLevel", "()I", "GetGetZoomLevelHandler")]
			get {
				const string __id = "getZoomLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_;
#pragma warning disable 0169
		static Delegate GetAddCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_Handler ()
		{
			if (cb_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_ == null)
				cb_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_);
			return cb_addCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_;
		}

		static IntPtr n_AddCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCircle (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='addCircle' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.CircleOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addCircle", "(Lcom/tencent/mapsdk/raster/model/CircleOptions;)Lcom/tencent/mapsdk/raster/model/Circle;", "GetAddCircle_Lcom_tencent_mapsdk_raster_model_CircleOptions_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.Circle AddCircle (global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions p0)
		{
			const string __id = "addCircle.(Lcom/tencent/mapsdk/raster/model/CircleOptions;)Lcom/tencent/mapsdk/raster/model/Circle;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Circle> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_;
#pragma warning disable 0169
		static Delegate GetAddGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_Handler ()
		{
			if (cb_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_ == null)
				cb_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_);
			return cb_addGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_;
		}

		static IntPtr n_AddGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddGroundOverlay (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='addGroundOverlay' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GroundOverlayOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addGroundOverlay", "(Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;", "GetAddGroundOverlay_Lcom_tencent_mapsdk_raster_model_GroundOverlayOptions_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay AddGroundOverlay (global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions p0)
		{
			const string __id = "addGroundOverlay.(Lcom/tencent/mapsdk/raster/model/GroundOverlayOptions;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_;
#pragma warning disable 0169
		static Delegate GetAddMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_Handler ()
		{
			if (cb_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ == null)
				cb_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_);
			return cb_addMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_;
		}

		static IntPtr n_AddMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddMarker (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.MarkerOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addMarker", "(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;", "GetAddMarker_Lcom_tencent_mapsdk_raster_model_MarkerOptions_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.Marker AddMarker (global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions p0)
		{
			const string __id = "addMarker.(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addOverlay_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetAddOverlay_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_addOverlay_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_addOverlay_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddOverlay_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_addOverlay_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static IntPtr n_AddOverlay_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOverlay (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='addOverlay' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.BitmapDescriptor'] and parameter[2][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[3][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Obsolete (@"deprecated")]
		[Register ("addOverlay", "(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;", "GetAddOverlay_Lcom_tencent_mapsdk_raster_model_BitmapDescriptor_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay AddOverlay (global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor p0, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2)
		{
			const string __id = "addOverlay.(Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_;
#pragma warning disable 0169
		static Delegate GetAddPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_Handler ()
		{
			if (cb_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_ == null)
				cb_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_);
			return cb_addPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_;
		}

		static IntPtr n_AddPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolygon (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='addPolygon' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.PolygonOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addPolygon", "(Lcom/tencent/mapsdk/raster/model/PolygonOptions;)Lcom/tencent/mapsdk/raster/model/Polygon;", "GetAddPolygon_Lcom_tencent_mapsdk_raster_model_PolygonOptions_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.Polygon AddPolygon (global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions p0)
		{
			const string __id = "addPolygon.(Lcom/tencent/mapsdk/raster/model/PolygonOptions;)Lcom/tencent/mapsdk/raster/model/Polygon;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polygon> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_;
#pragma warning disable 0169
		static Delegate GetAddPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_Handler ()
		{
			if (cb_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_ == null)
				cb_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_);
			return cb_addPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_;
		}

		static IntPtr n_AddPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolyline (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.PolylineOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addPolyline", "(Lcom/tencent/mapsdk/raster/model/PolylineOptions;)Lcom/tencent/mapsdk/raster/model/Polyline;", "GetAddPolyline_Lcom_tencent_mapsdk_raster_model_PolylineOptions_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.Polyline AddPolyline (global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions p0)
		{
			const string __id = "addPolyline.(Lcom/tencent/mapsdk/raster/model/PolylineOptions;)Lcom/tencent/mapsdk/raster/model/Polyline;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Polyline> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clearAllOverlays;
#pragma warning disable 0169
		static Delegate GetClearAllOverlaysHandler ()
		{
			if (cb_clearAllOverlays == null)
				cb_clearAllOverlays = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAllOverlays);
			return cb_clearAllOverlays;
		}

		static void n_ClearAllOverlays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllOverlays ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='clearAllOverlays' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearAllOverlays", "()V", "GetClearAllOverlaysHandler")]
		public virtual unsafe void ClearAllOverlays ()
		{
			const string __id = "clearAllOverlays.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_invalidate;
#pragma warning disable 0169
		static Delegate GetInvalidateHandler ()
		{
			if (cb_invalidate == null)
				cb_invalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Invalidate);
			return cb_invalidate;
		}

		static void n_Invalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Invalidate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='invalidate' and count(parameter)=0]"
		[Register ("invalidate", "()V", "GetInvalidateHandler")]
		public virtual unsafe void Invalidate ()
		{
			const string __id = "invalidate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_;
#pragma warning disable 0169
		static Delegate GetMoveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_Handler ()
		{
			if (cb_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_ == null)
				cb_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_MoveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_);
			return cb_moveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_;
		}

		static void n_MoveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveCamera (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='moveCamera' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.CameraUpdate']]"
		[Obsolete (@"deprecated")]
		[Register ("moveCamera", "(Lcom/tencent/tencentmap/mapsdk/map/CameraUpdate;)V", "GetMoveCamera_Lcom_tencent_tencentmap_mapsdk_map_CameraUpdate_Handler")]
		public virtual unsafe void MoveCamera (global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate p0)
		{
			const string __id = "moveCamera.(Lcom/tencent/tencentmap/mapsdk/map/CameraUpdate;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_postInvalidate;
#pragma warning disable 0169
		static Delegate GetPostInvalidateHandler ()
		{
			if (cb_postInvalidate == null)
				cb_postInvalidate = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PostInvalidate);
			return cb_postInvalidate;
		}

		static void n_PostInvalidate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PostInvalidate ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='postInvalidate' and count(parameter)=0]"
		[Register ("postInvalidate", "()V", "GetPostInvalidateHandler")]
		public virtual unsafe void PostInvalidate ()
		{
			const string __id = "postInvalidate.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_refreshMap;
#pragma warning disable 0169
		static Delegate GetRefreshMapHandler ()
		{
			if (cb_refreshMap == null)
				cb_refreshMap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RefreshMap);
			return cb_refreshMap;
		}

		static void n_RefreshMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshMap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='refreshMap' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("refreshMap", "()V", "GetRefreshMapHandler")]
		public virtual unsafe void RefreshMap ()
		{
			const string __id = "refreshMap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeOverlay_Lcom_tencent_mapsdk_raster_model_IOverlay_;
#pragma warning disable 0169
		static Delegate GetRemoveOverlay_Lcom_tencent_mapsdk_raster_model_IOverlay_Handler ()
		{
			if (cb_removeOverlay_Lcom_tencent_mapsdk_raster_model_IOverlay_ == null)
				cb_removeOverlay_Lcom_tencent_mapsdk_raster_model_IOverlay_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveOverlay_Lcom_tencent_mapsdk_raster_model_IOverlay_);
			return cb_removeOverlay_Lcom_tencent_mapsdk_raster_model_IOverlay_;
		}

		static void n_RemoveOverlay_Lcom_tencent_mapsdk_raster_model_IOverlay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.IOverlay p0 = (global::Com.Tencent.Mapsdk.Raster.Model.IOverlay)global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.IOverlay> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOverlay (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='removeOverlay' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.IOverlay']]"
		[Obsolete (@"deprecated")]
		[Register ("removeOverlay", "(Lcom/tencent/mapsdk/raster/model/IOverlay;)V", "GetRemoveOverlay_Lcom_tencent_mapsdk_raster_model_IOverlay_Handler")]
		public virtual unsafe void RemoveOverlay (global::Com.Tencent.Mapsdk.Raster.Model.IOverlay p0)
		{
			const string __id = "removeOverlay.(Lcom/tencent/mapsdk/raster/model/IOverlay;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLogoPosition_I;
#pragma warning disable 0169
		static Delegate GetSetLogoPosition_IHandler ()
		{
			if (cb_setLogoPosition_I == null)
				cb_setLogoPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLogoPosition_I);
			return cb_setLogoPosition_I;
		}

		static void n_SetLogoPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogoPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setLogoPosition", "(I)V", "GetSetLogoPosition_IHandler")]
		public virtual unsafe void SetLogoPosition (int p0)
		{
			const string __id = "setLogoPosition.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPinchEnabeled_Z;
#pragma warning disable 0169
		static Delegate GetSetPinchEnabeled_ZHandler ()
		{
			if (cb_setPinchEnabeled_Z == null)
				cb_setPinchEnabeled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPinchEnabeled_Z);
			return cb_setPinchEnabeled_Z;
		}

		static void n_SetPinchEnabeled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPinchEnabeled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='setPinchEnabeled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setPinchEnabeled", "(Z)V", "GetSetPinchEnabeled_ZHandler")]
		public virtual unsafe void SetPinchEnabeled (bool p0)
		{
			const string __id = "setPinchEnabeled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScaleControlsEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleControlsEnable_ZHandler ()
		{
			if (cb_setScaleControlsEnable_Z == null)
				cb_setScaleControlsEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleControlsEnable_Z);
			return cb_setScaleControlsEnable_Z;
		}

		static void n_SetScaleControlsEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleControlsEnable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='setScaleControlsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setScaleControlsEnable", "(Z)V", "GetSetScaleControlsEnable_ZHandler")]
		public virtual unsafe void SetScaleControlsEnable (bool p0)
		{
			const string __id = "setScaleControlsEnable.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScaleViewPosition_I;
#pragma warning disable 0169
		static Delegate GetSetScaleViewPosition_IHandler ()
		{
			if (cb_setScaleViewPosition_I == null)
				cb_setScaleViewPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScaleViewPosition_I);
			return cb_setScaleViewPosition_I;
		}

		static void n_SetScaleViewPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleViewPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='setScaleViewPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("setScaleViewPosition", "(I)V", "GetSetScaleViewPosition_IHandler")]
		public virtual unsafe void SetScaleViewPosition (int p0)
		{
			const string __id = "setScaleViewPosition.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScrollGesturesEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetScrollGesturesEnabled_ZHandler ()
		{
			if (cb_setScrollGesturesEnabled_Z == null)
				cb_setScrollGesturesEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScrollGesturesEnabled_Z);
			return cb_setScrollGesturesEnabled_Z;
		}

		static void n_SetScrollGesturesEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapFragmentUtil> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollGesturesEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapFragmentUtil']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setScrollGesturesEnabled", "(Z)V", "GetSetScrollGesturesEnabled_ZHandler")]
		public virtual unsafe void SetScrollGesturesEnabled (bool p0)
		{
			const string __id = "setScrollGesturesEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
