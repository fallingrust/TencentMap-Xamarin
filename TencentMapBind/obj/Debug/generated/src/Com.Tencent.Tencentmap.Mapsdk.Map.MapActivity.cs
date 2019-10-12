using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapActivity']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapActivity", DoNotGenerateAcw=true)]
	public abstract partial class MapActivity : global::Android.App.Activity {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/MapActivity", typeof (MapActivity));
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

		protected MapActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapActivity']/constructor[@name='MapActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MapActivity ()
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

		static Delegate cb_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
#pragma warning disable 0169
		static Delegate GetSetMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler ()
		{
			if (cb_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_ == null)
				cb_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_);
			return cb_setMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_;
		}

		static void n_SetMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapActivity __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapActivity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetMapView (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapActivity']/method[@name='setMapView' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.MapView']]"
		[Register ("setMapView", "(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V", "GetSetMapView_Lcom_tencent_tencentmap_mapsdk_map_MapView_Handler")]
		protected virtual unsafe void SetMapView (global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView p0)
		{
			const string __id = "setMapView.(Lcom/tencent/tencentmap/mapsdk/map/MapView;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapActivity", DoNotGenerateAcw=true)]
	internal partial class MapActivityInvoker : MapActivity {

		public MapActivityInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/tencent/tencentmap/mapsdk/map/MapActivity", typeof (MapActivityInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
