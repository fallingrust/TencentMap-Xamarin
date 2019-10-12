using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='OnMapHitListener']"
	[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
	[Register ("com/tencent/tencentmap/mapsdk/map/OnMapHitListener", "", "Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListenerInvoker")]
	public partial interface IOnMapHitListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/interface[@name='OnMapHitListener']/method[@name='onMapClick' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
[Obsolete (@"deprecated")]
		[Register ("onMapClick", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetOnMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_Handler:Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListenerInvoker, TencentMapBind")]
		void OnMapClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0);

	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/OnMapHitListener", DoNotGenerateAcw=true)]
	internal class IOnMapHitListenerInvoker : global::Java.Lang.Object, IOnMapHitListener {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/tencentmap/mapsdk/map/OnMapHitListener", typeof (IOnMapHitListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOnMapHitListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnMapHitListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.tencent.tencentmap.mapsdk.map.OnMapHitListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnMapHitListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetOnMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static void n_OnMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.IOnMapHitListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMapClick (p0);
		}
#pragma warning restore 0169

		IntPtr id_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_;
		public unsafe void OnMapClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			if (id_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ == IntPtr.Zero)
				id_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNIEnv.GetMethodID (class_ref, "onMapClick", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMapClick_Lcom_tencent_mapsdk_raster_model_LatLng_, __args);
		}

	}

	// event args for com.tencent.tencentmap.mapsdk.map.OnMapHitListener.onMapClick
	public partial class MapHitEventArgs : global::System.EventArgs {

		public MapHitEventArgs (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			this.p0 = p0;
		}

		global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0;
		public global::Com.Tencent.Mapsdk.Raster.Model.LatLng P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/tencent/tencentmap/mapsdk/map/OnMapHitListenerImplementor")]
	internal sealed partial class IOnMapHitListenerImplementor : global::Java.Lang.Object, IOnMapHitListener {

		object sender;

		public IOnMapHitListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/tencent/tencentmap/mapsdk/map/OnMapHitListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<MapHitEventArgs> Handler;
#pragma warning restore 0649

		public void OnMapClick (global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0)
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new MapHitEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnMapHitListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
