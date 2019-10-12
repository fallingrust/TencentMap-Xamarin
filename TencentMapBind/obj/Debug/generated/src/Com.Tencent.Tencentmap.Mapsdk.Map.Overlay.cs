using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/Overlay", DoNotGenerateAcw=true)]
	public partial class Overlay : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/field[@name='SHADOW_X_SKEW']"
		[Register ("SHADOW_X_SKEW")]
		protected const float ShadowXSkew = (float) -0.89;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/field[@name='SHADOW_Y_SCALE']"
		[Register ("SHADOW_Y_SCALE")]
		protected const float ShadowYScale = (float) 0.5;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/field[@name='isVisible']"
		[Register ("isVisible")]
		protected bool IsVisible {
			get {
				const string __id = "isVisible.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isVisible.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/field[@name='mapView']"
		[Register ("mapView")]
		protected global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView MapView {
			get {
				const string __id = "mapView.Lcom/tencent/tencentmap/mapsdk/map/MapView;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mapView.Lcom/tencent/tencentmap/mapsdk/map/MapView;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/Overlay", typeof (Overlay));
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

		protected Overlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/constructor[@name='Overlay' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Overlay ()
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

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetId);
			return cb_getId;
		}

		static IntPtr n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Id);
		}
#pragma warning restore 0169

		public virtual unsafe string Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get {
				const string __id = "getId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		public virtual unsafe bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				const string __id = "setVisible.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getZIndex;
#pragma warning disable 0169
		static Delegate GetGetZIndexHandler ()
		{
			if (cb_getZIndex == null)
				cb_getZIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetZIndex);
			return cb_getZIndex;
		}

		static float n_GetZIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setZIndex_F;
#pragma warning disable 0169
		static Delegate GetSetZIndex_FHandler ()
		{
			if (cb_setZIndex_F == null)
				cb_setZIndex_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZIndex_F);
			return cb_setZIndex_F;
		}

		static void n_SetZIndex_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZIndex = p0;
		}
#pragma warning restore 0169

		public virtual unsafe float ZIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='getZIndex' and count(parameter)=0]"
			[Register ("getZIndex", "()F", "GetGetZIndexHandler")]
			get {
				const string __id = "getZIndex.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='setZIndex' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZIndex", "(F)V", "GetSetZIndex_FHandler")]
			set {
				const string __id = "setZIndex.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_checkInBounds;
#pragma warning disable 0169
		static Delegate GetCheckInBoundsHandler ()
		{
			if (cb_checkInBounds == null)
				cb_checkInBounds = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CheckInBounds);
			return cb_checkInBounds;
		}

		static bool n_CheckInBounds (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckInBounds ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='checkInBounds' and count(parameter)=0]"
		[Register ("checkInBounds", "()Z", "GetCheckInBoundsHandler")]
		public virtual unsafe bool CheckInBounds ()
		{
			const string __id = "checkInBounds.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_ == null)
				cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_);
			return cb_draw_Landroid_graphics_Canvas_;
		}

		static void n_Draw_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='draw' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas p0)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static void n_Draw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='draw' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("draw", "(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "GetDraw_Landroid_graphics_Canvas_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		protected virtual unsafe void Draw (global::Android.Graphics.Canvas p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;Lcom/tencent/tencentmap/mapsdk/map/MapView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_hashCodeRemote;
#pragma warning disable 0169
		static Delegate GetHashCodeRemoteHandler ()
		{
			if (cb_hashCodeRemote == null)
				cb_hashCodeRemote = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_HashCodeRemote);
			return cb_hashCodeRemote;
		}

		static int n_HashCodeRemote (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HashCodeRemote ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='hashCodeRemote' and count(parameter)=0]"
		[Register ("hashCodeRemote", "()I", "GetHashCodeRemoteHandler")]
		public virtual unsafe int HashCodeRemote ()
		{
			const string __id = "hashCodeRemote.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetInit_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Init_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_init_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static void n_Init_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Init (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='init' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("init", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "GetInit_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual unsafe void Init (global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0)
		{
			const string __id = "init.(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
#pragma warning disable 0169
		static Delegate GetOnEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler ()
		{
			if (cb_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_ == null)
				cb_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_);
			return cb_onEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_;
		}

		static void n_OnEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEmptyTap (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onEmptyTap' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint']]"
		[Register ("onEmptyTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V", "GetOnEmptyTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Handler")]
		public virtual unsafe void OnEmptyTap (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0)
		{
			const string __id = "onEmptyTap.(Lcom/tencent/mapsdk/raster/model/GeoPoint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetOnLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_onLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static bool n_OnLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p2 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnLongPress (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onLongPress' and count(parameter)=3 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("onLongPress", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetOnLongPress_Lcom_tencent_mapsdk_raster_model_GeoPoint_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual unsafe bool OnLongPress (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Android.Views.MotionEvent p1, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p2)
		{
			const string __id = "onLongPress.(Lcom/tencent/mapsdk/raster/model/GeoPoint;Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onRemoveOverlay;
#pragma warning disable 0169
		static Delegate GetOnRemoveOverlayHandler ()
		{
			if (cb_onRemoveOverlay == null)
				cb_onRemoveOverlay = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRemoveOverlay);
			return cb_onRemoveOverlay;
		}

		static void n_OnRemoveOverlay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRemoveOverlay ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onRemoveOverlay' and count(parameter)=0]"
		[Register ("onRemoveOverlay", "()V", "GetOnRemoveOverlayHandler")]
		public virtual unsafe void OnRemoveOverlay ()
		{
			const string __id = "onRemoveOverlay.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetOnTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_onTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static bool n_OnTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTap (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onTap' and count(parameter)=2 and parameter[1][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("onTap", "(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetOnTap_Lcom_tencent_mapsdk_raster_model_GeoPoint_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual unsafe bool OnTap (global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
		{
			const string __id = "onTap.(Lcom/tencent/mapsdk/raster/model/GeoPoint;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetOnTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_onTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static bool n_OnTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouchEvent (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='onTouchEvent' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("onTouchEvent", "(Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z", "GetOnTouchEvent_Landroid_view_MotionEvent_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		public virtual unsafe bool OnTouchEvent (global::Android.Views.MotionEvent p0, global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p1)
		{
			const string __id = "onTouchEvent.(Landroid/view/MotionEvent;Lcom/tencent/tencentmap/mapsdk/map/MapView;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='Overlay']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			const string __id = "remove.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
