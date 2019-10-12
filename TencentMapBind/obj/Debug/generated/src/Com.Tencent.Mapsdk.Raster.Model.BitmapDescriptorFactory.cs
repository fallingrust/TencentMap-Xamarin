using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Mapsdk.Raster.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']"
	[global::Android.Runtime.Register ("com/tencent/mapsdk/raster/model/BitmapDescriptorFactory", DoNotGenerateAcw=true)]
	public sealed partial class BitmapDescriptorFactory : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/mapsdk/raster/model/BitmapDescriptorFactory", typeof (BitmapDescriptorFactory));
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

		internal BitmapDescriptorFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/constructor[@name='BitmapDescriptorFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BitmapDescriptorFactory ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='defaultMarker' and count(parameter)=0]"
		[Register ("defaultMarker", "()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor DefaultMarker ()
		{
			const string __id = "defaultMarker.()Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromAsset' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromAsset", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromAsset (string p0)
		{
			const string __id = "fromAsset.(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("fromBitmap", "(Landroid/graphics/Bitmap;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromBitmap (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "fromBitmap.(Landroid/graphics/Bitmap;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromFile", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromFile (string p0)
		{
			const string __id = "fromFile.(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromPath", "(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromPath (string p0)
		{
			const string __id = "fromPath.(Ljava/lang/String;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromResource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromResource", "(I)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromResource (int p0)
		{
			const string __id = "fromResource.(I)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.mapsdk.raster.model']/class[@name='BitmapDescriptorFactory']/method[@name='fromView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("fromView", "(Landroid/view/View;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;", "")]
		public static unsafe global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor FromView (global::Android.Views.View p0)
		{
			const string __id = "fromView.(Landroid/view/View;)Lcom/tencent/mapsdk/raster/model/BitmapDescriptor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Tencent.Mapsdk.Raster.Model.BitmapDescriptor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
