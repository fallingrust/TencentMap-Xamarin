using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Rastercore.Tile {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/rastercore/tile/MapTile", DoNotGenerateAcw=true)]
	public partial class MapTile : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile.MapSource']"
		[global::Android.Runtime.Register ("com/tencent/mapsdk/rastercore/tile/MapTile$MapSource", DoNotGenerateAcw=true)]
		public sealed partial class MapSource : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile.MapSource']/field[@name='CUSTOMER']"
			[Register ("CUSTOMER")]
			public static global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource Customer {
				get {
					const string __id = "CUSTOMER.Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile.MapSource']/field[@name='SATELLITE']"
			[Register ("SATELLITE")]
			public static global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource Satellite {
				get {
					const string __id = "SATELLITE.Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile.MapSource']/field[@name='TENCENT']"
			[Register ("TENCENT")]
			public static global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource Tencent {
				get {
					const string __id = "TENCENT.Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile.MapSource']/field[@name='TRAFFIC']"
			[Register ("TRAFFIC")]
			public static global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource Traffic {
				get {
					const string __id = "TRAFFIC.Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile.MapSource']/field[@name='WORLD']"
			[Register ("WORLD")]
			public static global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource World {
				get {
					const string __id = "WORLD.Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/rastercore/tile/MapTile$MapSource", typeof (MapSource));
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

			internal MapSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile.MapSource']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;", "")]
			public static unsafe global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile.MapSource']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;", "")]
			public static unsafe global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource[] Values ()
			{
				const string __id = "values.()[Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/rastercore/tile/MapTile", typeof (MapTile));
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

		protected MapTile (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_a;
#pragma warning disable 0169
		static Delegate GetAHandler ()
		{
			if (cb_a == null)
				cb_a = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_A);
			return cb_a;
		}

		static int n_A (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.A ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile']/method[@name='a' and count(parameter)=0]"
		[Register ("a", "()I", "GetAHandler")]
		public virtual unsafe int A ()
		{
			const string __id = "a.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_a_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_a_Landroid_graphics_Canvas_ == null)
				cb_a_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_A_Landroid_graphics_Canvas_);
			return cb_a_Landroid_graphics_Canvas_;
		}

		static bool n_A_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.A (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("a", "(Landroid/graphics/Canvas;)Z", "GetA_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe bool A (global::Android.Graphics.Canvas p0)
		{
			const string __id = "a.(Landroid/graphics/Canvas;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_a_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetA_Landroid_graphics_PointF_Handler ()
		{
			if (cb_a_Landroid_graphics_PointF_ == null)
				cb_a_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Landroid_graphics_PointF_);
			return cb_a_Landroid_graphics_PointF_;
		}

		static void n_A_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile']/method[@name='a' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("a", "(Landroid/graphics/PointF;)V", "GetA_Landroid_graphics_PointF_Handler")]
		public virtual unsafe void A (global::Android.Graphics.PointF p0)
		{
			const string __id = "a.(Landroid/graphics/PointF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_a_Lcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_;
#pragma warning disable 0169
		static Delegate GetA_Lcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_Handler ()
		{
			if (cb_a_Lcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_ == null)
				cb_a_Lcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_A_Lcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_);
			return cb_a_Lcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_;
		}

		static void n_A_Lcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource p0 = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.A (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile']/method[@name='a' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.rastercore.tile.MapTile.MapSource']]"
		[Register ("a", "(Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;)V", "GetA_Lcom_tencent_mapsdk_rastercore_tile_MapTile_MapSource_Handler")]
		public virtual unsafe void A (global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource p0)
		{
			const string __id = "a.(Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile']/method[@name='b' and count(parameter)=1 and parameter[1][@type='com.tencent.mapsdk.rastercore.tile.MapTile.MapSource']]"
		[Register ("b", "(Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;)I", "")]
		public static unsafe int B (global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile.MapSource p0)
		{
			const string __id = "b.(Lcom/tencent/mapsdk/rastercore/tile/MapTile$MapSource;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_c;
#pragma warning disable 0169
		static Delegate GetCHandler ()
		{
			if (cb_c == null)
				cb_c = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_C);
			return cb_c;
		}

		static void n_C (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile __this = global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Rastercore.Tile.MapTile> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.C ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.rastercore.tile']/class[@name='MapTile']/method[@name='c' and count(parameter)=0]"
		[Register ("c", "()V", "GetCHandler")]
		public virtual unsafe void C ()
		{
			const string __id = "c.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
