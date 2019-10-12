using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Tencentmap.Mapsdk.Map {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']"
	[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapView", DoNotGenerateAcw=true)]
	public partial class MapView : global::Android.Widget.FrameLayout {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']"
		[global::Android.Runtime.Register ("com/tencent/tencentmap/mapsdk/map/MapView$LayoutParams", DoNotGenerateAcw=true)]
		public partial class LayoutParams : global::Android.Widget.FrameLayout.LayoutParams {


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='BOTTOM']"
			[Register ("BOTTOM")]
			public const int Bottom = (int) 80;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='BOTTOM_CENTER']"
			[Register ("BOTTOM_CENTER")]
			public const int BottomCenter = (int) 81;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='CENTER']"
			[Register ("CENTER")]
			public const int Center = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='CENTER_HORIZONTAL']"
			[Register ("CENTER_HORIZONTAL")]
			public const int CenterHorizontal = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='CENTER_VERTICAL']"
			[Register ("CENTER_VERTICAL")]
			public const int CenterVertical = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='LEFT']"
			[Register ("LEFT")]
			public const int Left = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='MODE_MAP']"
			[Register ("MODE_MAP")]
			public const int ModeMap = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='MODE_VIEW']"
			[Register ("MODE_VIEW")]
			public const int ModeView = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='RIGHT']"
			[Register ("RIGHT")]
			public const int Right = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='TOP']"
			[Register ("TOP")]
			public const int Top = (int) 48;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='TOP_LEFT']"
			[Register ("TOP_LEFT")]
			public const int TopLeft = (int) 51;


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/field[@name='mode']"
			[Register ("mode")]
			public int Mode {
				get {
					const string __id = "mode.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "mode.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/MapView$LayoutParams", typeof (LayoutParams));
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

			protected LayoutParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=1 and parameter[1][@type='android.view.ViewGroup.LayoutParams']]"
			[Register (".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			protected unsafe LayoutParams (global::Android.Views.ViewGroup.LayoutParams p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Landroid/view/ViewGroup$LayoutParams;)V";

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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe LayoutParams (int p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(II)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IILcom/tencent/mapsdk/raster/model/GeoPoint;I)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe LayoutParams (int p0, int p1, global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p2, int p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILcom/tencent/mapsdk/raster/model/GeoPoint;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					__args [3] = new JniArgumentValue (p3);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.mapsdk.raster.model.GeoPoint'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register (".ctor", "(IILcom/tencent/mapsdk/raster/model/GeoPoint;III)V", "")]
			[Obsolete (@"deprecated")]
			public unsafe LayoutParams (int p0, int p1, global::Com.Tencent.Mapsdk.Raster.Model.GeoPoint p2, int p3, int p4, int p5)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILcom/tencent/mapsdk/raster/model/GeoPoint;III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (p5);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[4][@type='int']]"
			[Register (".ctor", "(IILcom/tencent/mapsdk/raster/model/LatLng;I)V", "")]
			public unsafe LayoutParams (int p0, int p1, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2, int p3)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILcom/tencent/mapsdk/raster/model/LatLng;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					__args [3] = new JniArgumentValue (p3);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/constructor[@name='MapView.LayoutParams' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
			[Register (".ctor", "(IILcom/tencent/mapsdk/raster/model/LatLng;III)V", "")]
			public unsafe LayoutParams (int p0, int p1, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2, int p3, int p4, int p5)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILcom/tencent/mapsdk/raster/model/LatLng;III)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [6];
					__args [0] = new JniArgumentValue (p0);
					__args [1] = new JniArgumentValue (p1);
					__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
					__args [3] = new JniArgumentValue (p3);
					__args [4] = new JniArgumentValue (p4);
					__args [5] = new JniArgumentValue (p5);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_getPoint;
#pragma warning disable 0169
			static Delegate GetGetPointHandler ()
			{
				if (cb_getPoint == null)
					cb_getPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPoint);
				return cb_getPoint;
			}

			static IntPtr n_GetPoint (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView.LayoutParams __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Point);
			}
#pragma warning restore 0169

			static Delegate cb_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
			static Delegate GetSetPoint_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
			{
				if (cb_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
					cb_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPoint_Lcom_tencent_mapsdk_raster_model_LatLng_);
				return cb_setPoint_Lcom_tencent_mapsdk_raster_model_LatLng_;
			}

			static void n_SetPoint_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView.LayoutParams __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView.LayoutParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Tencent.Mapsdk.Raster.Model.LatLng p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Point = p0;
			}
#pragma warning restore 0169

			public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLng Point {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/method[@name='getPoint' and count(parameter)=0]"
				[Register ("getPoint", "()Lcom/tencent/mapsdk/raster/model/LatLng;", "GetGetPointHandler")]
				get {
					const string __id = "getPoint.()Lcom/tencent/mapsdk/raster/model/LatLng;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView.LayoutParams']/method[@name='setPoint' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.LatLng']]"
				[Register ("setPoint", "(Lcom/tencent/mapsdk/raster/model/LatLng;)V", "GetSetPoint_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
				set {
					const string __id = "setPoint.(Lcom/tencent/mapsdk/raster/model/LatLng;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/tencentmap/mapsdk/map/MapView", typeof (MapView));
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

		protected MapView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/constructor[@name='MapView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.tencent.mapsdk.raster.model.TencentMapOptions']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/tencent/mapsdk/raster/model/TencentMapOptions;)V", "")]
		public unsafe MapView (global::Android.Content.Context p0, global::Com.Tencent.Mapsdk.Raster.Model.TencentMapOptions p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/tencent/mapsdk/raster/model/TencentMapOptions;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getController;
#pragma warning disable 0169
		static Delegate GetGetControllerHandler ()
		{
			if (cb_getController == null)
				cb_getController = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetController);
			return cb_getController;
		}

		static IntPtr n_GetController (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Controller);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController Controller {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getController' and count(parameter)=0]"
			[Register ("getController", "()Lcom/tencent/tencentmap/mapsdk/map/MapController;", "GetGetControllerHandler")]
			get {
				const string __id = "getController.()Lcom/tencent/tencentmap/mapsdk/map/MapController;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe bool IsAppKeyAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='isAppKeyAvailable' and count(parameter)=0]"
			[Register ("isAppKeyAvailable", "()Z", "GetIsAppKeyAvailableHandler")]
			get {
				const string __id = "isAppKeyAvailable.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LatitudeSpan;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int LatitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getLatitudeSpan' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LongitudeSpan;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int LongitudeSpan {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getLongitudeSpan' and count(parameter)=0]"
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

		static Delegate cb_getMap;
#pragma warning disable 0169
		static Delegate GetGetMapHandler ()
		{
			if (cb_getMap == null)
				cb_getMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMap);
			return cb_getMap;
		}

		static IntPtr n_GetMap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Map);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap Map {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMap' and count(parameter)=0]"
			[Register ("getMap", "()Lcom/tencent/tencentmap/mapsdk/map/TencentMap;", "GetGetMapHandler")]
			get {
				const string __id = "getMap.()Lcom/tencent/tencentmap/mapsdk/map/TencentMap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.TencentMap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapCenter);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.LatLng MapCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMapCenter' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MapController);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::Com.Tencent.Tencentmap.Mapsdk.Map.MapController MapController {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMapController' and count(parameter)=0]"
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

		static Delegate cb_getMaxZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomLevelHandler ()
		{
			if (cb_getMaxZoomLevel == null)
				cb_getMaxZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxZoomLevel);
			return cb_getMaxZoomLevel;
		}

		static int n_GetMaxZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoomLevel;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int MaxZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMaxZoomLevel' and count(parameter)=0]"
			[Register ("getMaxZoomLevel", "()I", "GetGetMaxZoomLevelHandler")]
			get {
				const string __id = "getMaxZoomLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinZoomLevel;
#pragma warning disable 0169
		static Delegate GetGetMinZoomLevelHandler ()
		{
			if (cb_getMinZoomLevel == null)
				cb_getMinZoomLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinZoomLevel);
			return cb_getMinZoomLevel;
		}

		static int n_GetMinZoomLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoomLevel;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int MinZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getMinZoomLevel' and count(parameter)=0]"
			[Register ("getMinZoomLevel", "()I", "GetGetMinZoomLevelHandler")]
			get {
				const string __id = "getMinZoomLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Projection);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Tencent.Tencentmap.Mapsdk.Map.Projection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getProjection' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Satellite = p0;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool Satellite {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='isSatellite' and count(parameter)=0]"
			[Register ("isSatellite", "()Z", "GetIsSatelliteHandler")]
			get {
				const string __id = "isSatellite.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setSatellite' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScalePerPixel;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe float ScalePerPixel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getScalePerPixel' and count(parameter)=0]"
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

		static Delegate cb_getUiSettings;
#pragma warning disable 0169
		static Delegate GetGetUiSettingsHandler ()
		{
			if (cb_getUiSettings == null)
				cb_getUiSettings = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUiSettings);
			return cb_getUiSettings;
		}

		static IntPtr n_GetUiSettings (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.UiSettings);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Tencent.Tencentmap.Mapsdk.Map.UiSettings UiSettings {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getUiSettings' and count(parameter)=0]"
			[Register ("getUiSettings", "()Lcom/tencent/tencentmap/mapsdk/map/UiSettings;", "GetGetUiSettingsHandler")]
			get {
				const string __id = "getUiSettings.()Lcom/tencent/tencentmap/mapsdk/map/UiSettings;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.UiSettings> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public unsafe string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getVersion' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomLevel;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int ZoomLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='getZoomLevel' and count(parameter)=0]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.CircleOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddCircle (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addCircle' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.CircleOptions']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlayOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddGroundOverlay (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addGroundOverlay' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.GroundOverlayOptions']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.MarkerOptions']]"
		[Obsolete (@"deprecated")]
		[Register ("addMarker", "(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;", "")]
		public unsafe global::Com.Tencent.Mapsdk.Raster.Model.Marker AddMarker (global::Com.Tencent.Mapsdk.Raster.Model.MarkerOptions p0)
		{
			const string __id = "addMarker.(Lcom/tencent/mapsdk/raster/model/MarkerOptions;)Lcom/tencent/mapsdk/raster/model/Marker;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.Marker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
#pragma warning disable 0169
		static Delegate GetAddOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler ()
		{
			if (cb_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ == null)
				cb_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_AddOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_);
			return cb_addOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_;
		}

		static IntPtr n_AddOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.LatLng> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOverlay (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addOverlay' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='com.tencent.mapsdk.raster.model.LatLng'] and parameter[3][@type='com.tencent.mapsdk.raster.model.LatLng']]"
		[Obsolete (@"deprecated")]
		[Register ("addOverlay", "(Landroid/graphics/Bitmap;Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;", "GetAddOverlay_Landroid_graphics_Bitmap_Lcom_tencent_mapsdk_raster_model_LatLng_Lcom_tencent_mapsdk_raster_model_LatLng_Handler")]
		public virtual unsafe global::Com.Tencent.Mapsdk.Raster.Model.GroundOverlay AddOverlay (global::Android.Graphics.Bitmap p0, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p1, global::Com.Tencent.Mapsdk.Raster.Model.LatLng p2)
		{
			const string __id = "addOverlay.(Landroid/graphics/Bitmap;Lcom/tencent/mapsdk/raster/model/LatLng;Lcom/tencent/mapsdk/raster/model/LatLng;)Lcom/tencent/mapsdk/raster/model/GroundOverlay;";
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addOverlay' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.Overlay']]"
		[Obsolete (@"deprecated")]
		[Register ("addOverlay", "(Lcom/tencent/tencentmap/mapsdk/map/Overlay;)Z", "")]
		public unsafe bool AddOverlay (global::Com.Tencent.Tencentmap.Mapsdk.Map.Overlay p0)
		{
			const string __id = "addOverlay.(Lcom/tencent/tencentmap/mapsdk/map/Overlay;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolygonOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolygon (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addPolygon' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.PolygonOptions']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.PolylineOptions> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddPolyline (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='addPolyline' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.PolylineOptions']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='clearAllOverlays' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearAllOverlays", "()V", "")]
		public unsafe void ClearAllOverlays ()
		{
			const string __id = "clearAllOverlays.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_layout;
#pragma warning disable 0169
		static Delegate GetLayoutHandler ()
		{
			if (cb_layout == null)
				cb_layout = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Layout);
			return cb_layout;
		}

		static void n_Layout (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Layout ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='layout' and count(parameter)=0]"
		[Register ("layout", "()V", "GetLayoutHandler")]
		public virtual unsafe void Layout ()
		{
			const string __id = "layout.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_layout_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetLayout_Landroid_view_View_Handler ()
		{
			if (cb_layout_Landroid_view_View_ == null)
				cb_layout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Layout_Landroid_view_View_);
			return cb_layout_Landroid_view_View_;
		}

		static void n_Layout_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Layout (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='layout' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("layout", "(Landroid/view/View;)V", "GetLayout_Landroid_view_View_Handler")]
		public virtual unsafe void Layout (global::Android.Views.View p0)
		{
			const string __id = "layout.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.CameraUpdate> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.MoveCamera (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='moveCamera' and count(parameter)=1 and parameter[1][@type='com.tencent.tencentmap.mapsdk.map.CameraUpdate']]"
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

		static Delegate cb_onCreate_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreate_Landroid_os_Bundle_ == null)
				cb_onCreate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_os_Bundle_);
			return cb_onCreate_Landroid_os_Bundle_;
		}

		static void n_OnCreate_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onCreate' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreate", "(Landroid/os/Bundle;)V", "GetOnCreate_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnCreate (global::Android.OS.Bundle p0)
		{
			const string __id = "onCreate.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDestroyView;
#pragma warning disable 0169
		static Delegate GetOnDestroyViewHandler ()
		{
			if (cb_onDestroyView == null)
				cb_onDestroyView = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroyView);
			return cb_onDestroyView;
		}

		static void n_OnDestroyView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroyView ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onDestroyView' and count(parameter)=0]"
		[Register ("onDestroyView", "()V", "GetOnDestroyViewHandler")]
		public virtual unsafe void OnDestroyView ()
		{
			const string __id = "onDestroyView.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onLowMemory;
#pragma warning disable 0169
		static Delegate GetOnLowMemoryHandler ()
		{
			if (cb_onLowMemory == null)
				cb_onLowMemory = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnLowMemory);
			return cb_onLowMemory;
		}

		static void n_OnLowMemory (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLowMemory ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onLowMemory' and count(parameter)=0]"
		[Register ("onLowMemory", "()V", "GetOnLowMemoryHandler")]
		public virtual unsafe void OnLowMemory ()
		{
			const string __id = "onLowMemory.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onRestart;
#pragma warning disable 0169
		static Delegate GetOnRestartHandler ()
		{
			if (cb_onRestart == null)
				cb_onRestart = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnRestart);
			return cb_onRestart;
		}

		static void n_OnRestart (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRestart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onRestart' and count(parameter)=0]"
		[Register ("onRestart", "()V", "GetOnRestartHandler")]
		public virtual unsafe void OnRestart ()
		{
			const string __id = "onRestart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceState_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSaveInstanceState_Landroid_os_Bundle_ == null)
				cb_onSaveInstanceState_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState_Landroid_os_Bundle_);
			return cb_onSaveInstanceState_Landroid_os_Bundle_;
		}

		static void n_OnSaveInstanceState_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSaveInstanceState (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onSaveInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSaveInstanceState", "(Landroid/os/Bundle;)V", "GetOnSaveInstanceState_Landroid_os_Bundle_Handler")]
		public virtual unsafe void OnSaveInstanceState (global::Android.OS.Bundle p0)
		{
			const string __id = "onSaveInstanceState.(Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RefreshMap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='refreshMap' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='removeOverlay' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.raster.model.IOverlay']]"
		[Obsolete (@"deprecated")]
		[Register ("removeOverlay", "(Lcom/tencent/mapsdk/raster/model/IOverlay;)V", "")]
		public unsafe void RemoveOverlay (global::Com.Tencent.Mapsdk.Raster.Model.IOverlay p0)
		{
			const string __id = "removeOverlay.(Lcom/tencent/mapsdk/raster/model/IOverlay;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLogoPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setLogoPosition' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPinchEnabeled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setPinchEnabeled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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

		static Delegate cb_setScalControlsEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetScalControlsEnable_ZHandler ()
		{
			if (cb_setScalControlsEnable_Z == null)
				cb_setScalControlsEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScalControlsEnable_Z);
			return cb_setScalControlsEnable_Z;
		}

		static void n_SetScalControlsEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScalControlsEnable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setScalControlsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setScalControlsEnable", "(Z)V", "GetSetScalControlsEnable_ZHandler")]
		public virtual unsafe void SetScalControlsEnable (bool p0)
		{
			const string __id = "setScalControlsEnable.(Z)V";
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleControlsEnable (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setScaleControlsEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleViewPosition (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setScaleViewPosition' and count(parameter)=1 and parameter[1][@type='int']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollGesturesEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='setScrollGesturesEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
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
			global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Tencentmap.Mapsdk.Map.MapView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.tencentmap.mapsdk.map']/class[@name='MapView']/method[@name='stopAnimation' and count(parameter)=0]"
		[Register ("stopAnimation", "()V", "GetStopAnimationHandler")]
		public virtual unsafe void StopAnimation ()
		{
			const string __id = "stopAnimation.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
