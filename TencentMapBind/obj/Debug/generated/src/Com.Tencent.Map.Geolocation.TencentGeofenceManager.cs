using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Tencent.Map.Geolocation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofenceManager']"
	[global::Android.Runtime.Register ("com/tencent/map/geolocation/TencentGeofenceManager", DoNotGenerateAcw=true)]
	public sealed partial class TencentGeofenceManager : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/tencent/map/geolocation/TencentGeofenceManager", typeof (TencentGeofenceManager));
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

		internal TencentGeofenceManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofenceManager']/constructor[@name='TencentGeofenceManager' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TencentGeofenceManager (global::Android.Content.Context p0)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofenceManager']/method[@name='addFence' and count(parameter)=2 and parameter[1][@type='com.tencent.map.geolocation.TencentGeofence'] and parameter[2][@type='android.app.PendingIntent']]"
		[Register ("addFence", "(Lcom/tencent/map/geolocation/TencentGeofence;Landroid/app/PendingIntent;)V", "")]
		public unsafe void AddFence (global::Com.Tencent.Map.Geolocation.TencentGeofence p0, global::Android.App.PendingIntent p1)
		{
			const string __id = "addFence.(Lcom/tencent/map/geolocation/TencentGeofence;Landroid/app/PendingIntent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofenceManager']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public unsafe void Destroy ()
		{
			const string __id = "destroy.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofenceManager']/method[@name='removeAllFences' and count(parameter)=0]"
		[Register ("removeAllFences", "()V", "")]
		public unsafe void RemoveAllFences ()
		{
			const string __id = "removeAllFences.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofenceManager']/method[@name='removeFence' and count(parameter)=1 and parameter[1][@type='com.tencent.map.geolocation.TencentGeofence']]"
		[Register ("removeFence", "(Lcom/tencent/map/geolocation/TencentGeofence;)V", "")]
		public unsafe void RemoveFence (global::Com.Tencent.Map.Geolocation.TencentGeofence p0)
		{
			const string __id = "removeFence.(Lcom/tencent/map/geolocation/TencentGeofence;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.tencent.map.geolocation']/class[@name='TencentGeofenceManager']/method[@name='removeFence' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("removeFence", "(Ljava/lang/String;)V", "")]
		public unsafe void RemoveFence (string p0)
		{
			const string __id = "removeFence.(Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
