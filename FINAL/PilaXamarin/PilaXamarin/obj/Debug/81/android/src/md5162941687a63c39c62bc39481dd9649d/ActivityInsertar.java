package md5162941687a63c39c62bc39481dd9649d;


public class ActivityInsertar
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("PilaXamarin.ActivityInsertar, PilaXamarin", ActivityInsertar.class, __md_methods);
	}


	public ActivityInsertar ()
	{
		super ();
		if (getClass () == ActivityInsertar.class)
			mono.android.TypeManager.Activate ("PilaXamarin.ActivityInsertar, PilaXamarin", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}