using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/Projection", DoNotGenerateAcw=true)]
	public partial class Projection : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/Projection", typeof (Projection));
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

		protected Projection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		public virtual unsafe int LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='getLatitudeSpan' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		public virtual unsafe int LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='getLongitudeSpan' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalePerPixel;
		}
#pragma warning restore 0169

		public virtual unsafe float ScalePerPixel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='getScalePerPixel' and count(parameter)=0]"
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

		static Delegate cb_getVisibleRegion;
#pragma warning disable 0169
		static Delegate GetGetVisibleRegionHandler ()
		{
			if (cb_getVisibleRegion == null)
				cb_getVisibleRegion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisibleRegion);
			return cb_getVisibleRegion;
		}

		static IntPtr n_GetVisibleRegion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisibleRegion);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.VisibleRegion VisibleRegion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='getVisibleRegion' and count(parameter)=0]"
			[Register ("getVisibleRegion", "()Lcom/tencent/mapsdk/raster/model/VisibleRegion;", "GetGetVisibleRegionHandler")]
			get {
				const string __id = "getVisibleRegion.()Lcom/tencent/mapsdk/raster/model/VisibleRegion;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.VisibleRegion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetDistanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler ()
		{
			if (cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == null)
				cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_DistanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_);
			return cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		}

		static double n_DistanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p1, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceBetween (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='distanceBetween' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.mapsdk.raster.model.GeoPoint']]"
		[Obsolete (@"deprecated")]
		[Register ("distanceBetween", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/mapsdk/raster/model/GeoPoint;)D", "GetDistanceBetween_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler")]
		public virtual unsafe double DistanceBetween (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p1)
		{
			const string __id = "distanceBetween.(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/mapsdk/raster/model/GeoPoint;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetDistanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, double>) n_DistanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_distanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static double n_DistanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p1, JniHandleOwnership.DoNotTransfer);
			double __ret = __this.DistanceBetween (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='distanceBetween' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[2][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("distanceBetween", "(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)D", "GetDistanceBetween_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual unsafe double DistanceBetween (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1)
		{
			const string __id = "distanceBetween.(Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_fromPixels_II;
#pragma warning disable 0169
		static Delegate GetFromPixels_IIHandler ()
		{
			if (cb_fromPixels_II == null)
				cb_fromPixels_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_FromPixels_II);
			return cb_fromPixels_II;
		}

		static IntPtr n_FromPixels_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FromPixels (p0, p1));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='fromPixels' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("fromPixels", "(II)Lcom/tencent/mapsdk/raster/model/GeoPoint;", "GetFromPixels_IIHandler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint FromPixels (int p0, int p1)
		{
			const string __id = "fromPixels.(II)Lcom/tencent/mapsdk/raster/model/GeoPoint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fromScreenLocation_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetFromScreenLocation_Landroid_graphics_Point_Handler ()
		{
			if (cb_fromScreenLocation_Landroid_graphics_Point_ == null)
				cb_fromScreenLocation_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FromScreenLocation_Landroid_graphics_Point_);
			return cb_fromScreenLocation_Landroid_graphics_Point_;
		}

		static IntPtr n_FromScreenLocation_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FromScreenLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='fromScreenLocation' and count(parameter)=1 and parameter[1][@type='android.graphics.Point']]"
		[Register ("fromScreenLocation", "(Landroid/graphics/Point;)Lcom/tencent/mapsdk/raster/model/LatLng;", "GetFromScreenLocation_Landroid_graphics_Point_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLng FromScreenLocation (global::Android.Graphics.Point p0)
		{
			const string __id = "fromScreenLocation.(Landroid/graphics/Point;)Lcom/tencent/mapsdk/raster/model/LatLng;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_metersToEquatorPixels_F;
#pragma warning disable 0169
		static Delegate GetMetersToEquatorPixels_FHandler ()
		{
			if (cb_metersToEquatorPixels_F == null)
				cb_metersToEquatorPixels_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float>) n_MetersToEquatorPixels_F);
			return cb_metersToEquatorPixels_F;
		}

		static float n_MetersToEquatorPixels_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MetersToEquatorPixels (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='metersToEquatorPixels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("metersToEquatorPixels", "(F)F", "GetMetersToEquatorPixels_FHandler")]
		public virtual unsafe float MetersToEquatorPixels (float p0)
		{
			const string __id = "metersToEquatorPixels.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_metersToPixels_DD;
#pragma warning disable 0169
		static Delegate GetMetersToPixels_DDHandler ()
		{
			if (cb_metersToPixels_DD == null)
				cb_metersToPixels_DD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, float>) n_MetersToPixels_DD);
			return cb_metersToPixels_DD;
		}

		static float n_MetersToPixels_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MetersToPixels (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='metersToPixels' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("metersToPixels", "(DD)F", "GetMetersToPixels_DDHandler")]
		public virtual unsafe float MetersToPixels (double p0, double p1)
		{
			const string __id = "metersToPixels.(DD)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_;
#pragma warning disable 0169
		static Delegate GetToPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_Handler ()
		{
			if (cb_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_ == null)
				cb_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ToPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_);
			return cb_toPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_;
		}

		static IntPtr n_ToPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Point p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToPixels (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='toPixels' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='android.graphics.Point']]"
		[Obsolete (@"deprecated")]
		[Register ("toPixels", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;", "GetToPixels_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_graphics_Point_Handler")]
		public virtual unsafe global::Android.Graphics.Point ToPixels (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Android.Graphics.Point p1)
		{
			const string __id = "toPixels.(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/graphics/Point;)Landroid/graphics/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetToScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_toScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static IntPtr n_ToScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ToScreenLocation (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Projection']/method[@name='toScreenLocation' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Register ("toScreenLocation", "(Lcom/tencent/mapsdk/raster/model/LatLng;)Landroid/graphics/Point;", "GetToScreenLocation_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual unsafe global::Android.Graphics.Point ToScreenLocation (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			const string __id = "toScreenLocation.(Lcom/tencent/mapsdk/raster/model/LatLng;)Landroid/graphics/Point;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Point> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
