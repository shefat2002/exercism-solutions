public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }
    public override bool Equals(object obj)
    {
        if(obj is FacialFeatures other)
            return this.EyeColor == other.EyeColor && this.PhiltrumWidth == other.PhiltrumWidth;
        return false;
    }
    public override int GetHashCode() => HashCode.Combine(EyeColor, PhiltrumWidth);
}

public class Identity
{
    
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }
    

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }
    public override bool Equals(object obj)
    {
        if(obj is Identity other)
            return this.Email == other.Email && Equals(this.FacialFeatures, other.FacialFeatures);
        return false;
    }
    
    public override int GetHashCode() => HashCode.Combine(Email, FacialFeatures);
}

public class Authenticator
{
    public HashSet<Identity> Faces = new();
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => (Equals(faceA, faceB));
    

    public bool IsAdmin(Identity identity) =>(identity.Email == "admin@exerc.ism" && identity.FacialFeatures.EyeColor == "green" && identity.FacialFeatures.PhiltrumWidth == 0.9m);

    public bool Register(Identity identity)
    {
        if(Faces.Contains(identity)) return false;
        Faces.Add(identity);
        return true;
    }

    public bool IsRegistered(Identity identity) => (Faces.Contains(identity)) ;
    

    public static bool AreSameObject(Identity identityA, Identity identityB) => ReferenceEquals(identityA, identityB);
}
