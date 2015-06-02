// Generated by ProtoGen, Version=2.3.0.277, Culture=neutral, PublicKeyToken=8fd7408b07f8d2cd.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Proto {
  
  public static partial class PlayerInfo {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    internal static pbd::MessageDescriptor internal__static_PlayerInfo__Descriptor;
    internal static pb::FieldAccess.FieldAccessorTable<global::PlayerInfo, global::PlayerInfo.Builder> internal__static_PlayerInfo__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static PlayerInfo() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          "ChBQbGF5ZXJJbmZvLnByb3RvIlkKClBsYXllckluZm8SHAoIVHlwZU5hbWUY" + 
          "ASACKAk6ClBsYXllckluZm8SDAoETmFtZRgCIAEoCRINCgVFbWFpbBgDIAEo" + 
          "CRIQCghDaGVja1N1bRgEIAEoBQ==");
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_PlayerInfo__Descriptor = Descriptor.MessageTypes[0];
        internal__static_PlayerInfo__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::PlayerInfo, global::PlayerInfo.Builder>(internal__static_PlayerInfo__Descriptor,
                new string[] { "TypeName", "Name", "Email", "CheckSum", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
  }
}
#region Messages
public sealed partial class PlayerInfo : pb::GeneratedMessage<PlayerInfo, PlayerInfo.Builder> {
  private static readonly PlayerInfo defaultInstance = new Builder().BuildPartial();
  public static PlayerInfo DefaultInstance {
    get { return defaultInstance; }
  }
  
  public override PlayerInfo DefaultInstanceForType {
    get { return defaultInstance; }
  }
  
  protected override PlayerInfo ThisMessage {
    get { return this; }
  }
  
  public static pbd::MessageDescriptor Descriptor {
    get { return global::Proto.PlayerInfo.internal__static_PlayerInfo__Descriptor; }
  }
  
  protected override pb::FieldAccess.FieldAccessorTable<PlayerInfo, PlayerInfo.Builder> InternalFieldAccessors {
    get { return global::Proto.PlayerInfo.internal__static_PlayerInfo__FieldAccessorTable; }
  }
  
  public const int TypeNameFieldNumber = 1;
  private bool hasTypeName;
  private string typeName_ = "PlayerInfo";
  public bool HasTypeName {
    get { return hasTypeName; }
  }
  public string TypeName {
    get { return typeName_; }
  }
  
  public const int NameFieldNumber = 2;
  private bool hasName;
  private string name_ = "";
  public bool HasName {
    get { return hasName; }
  }
  public string Name {
    get { return name_; }
  }
  
  public const int EmailFieldNumber = 3;
  private bool hasEmail;
  private string email_ = "";
  public bool HasEmail {
    get { return hasEmail; }
  }
  public string Email {
    get { return email_; }
  }
  
  public const int CheckSumFieldNumber = 4;
  private bool hasCheckSum;
  private int checkSum_ = 0;
  public bool HasCheckSum {
    get { return hasCheckSum; }
  }
  public int CheckSum {
    get { return checkSum_; }
  }
  
  public override bool IsInitialized {
    get {
      if (!hasTypeName) return false;
      return true;
    }
  }
  
  public override void WriteTo(pb::CodedOutputStream output) {
    int size = SerializedSize;
    if (HasTypeName) {
      output.WriteString(1, TypeName);
    }
    if (HasName) {
      output.WriteString(2, Name);
    }
    if (HasEmail) {
      output.WriteString(3, Email);
    }
    if (HasCheckSum) {
      output.WriteInt32(4, CheckSum);
    }
    UnknownFields.WriteTo(output);
  }
  
  private int memoizedSerializedSize = -1;
  public override int SerializedSize {
    get {
      int size = memoizedSerializedSize;
      if (size != -1) return size;
      
      size = 0;
      if (HasTypeName) {
        size += pb::CodedOutputStream.ComputeStringSize(1, TypeName);
      }
      if (HasName) {
        size += pb::CodedOutputStream.ComputeStringSize(2, Name);
      }
      if (HasEmail) {
        size += pb::CodedOutputStream.ComputeStringSize(3, Email);
      }
      if (HasCheckSum) {
        size += pb::CodedOutputStream.ComputeInt32Size(4, CheckSum);
      }
      size += UnknownFields.SerializedSize;
      memoizedSerializedSize = size;
      return size;
    }
  }
  
  public static PlayerInfo ParseFrom(pb::ByteString data) {
    return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
  }
  public static PlayerInfo ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
    return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
  }
  public static PlayerInfo ParseFrom(byte[] data) {
    return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
  }
  public static PlayerInfo ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
    return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
  }
  public static PlayerInfo ParseFrom(global::System.IO.Stream input) {
    return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
  }
  public static PlayerInfo ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
    return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
  }
  public static PlayerInfo ParseDelimitedFrom(global::System.IO.Stream input) {
    return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
  }
  public static PlayerInfo ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
    return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
  }
  public static PlayerInfo ParseFrom(pb::CodedInputStream input) {
    return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
  }
  public static PlayerInfo ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
    return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
  }
  public static Builder CreateBuilder() { return new Builder(); }
  public override Builder ToBuilder() { return CreateBuilder(this); }
  public override Builder CreateBuilderForType() { return new Builder(); }
  public static Builder CreateBuilder(PlayerInfo prototype) {
    return (Builder) new Builder().MergeFrom(prototype);
  }
  
  public sealed partial class Builder : pb::GeneratedBuilder<PlayerInfo, Builder> {
    protected override Builder ThisBuilder {
      get { return this; }
    }
    public Builder() {}
    
    PlayerInfo result = new PlayerInfo();
    
    protected override PlayerInfo MessageBeingBuilt {
      get { return result; }
    }
    
    public override Builder Clear() {
      result = new PlayerInfo();
      return this;
    }
    
    public override Builder Clone() {
      return new Builder().MergeFrom(result);
    }
    
    public override pbd::MessageDescriptor DescriptorForType {
      get { return global::PlayerInfo.Descriptor; }
    }
    
    public override PlayerInfo DefaultInstanceForType {
      get { return global::PlayerInfo.DefaultInstance; }
    }
    
    public override PlayerInfo BuildPartial() {
      if (result == null) {
        throw new global::System.InvalidOperationException("build() has already been called on this Builder");
      }
      PlayerInfo returnMe = result;
      result = null;
      return returnMe;
    }
    
    public override Builder MergeFrom(pb::IMessage other) {
      if (other is PlayerInfo) {
        return MergeFrom((PlayerInfo) other);
      } else {
        base.MergeFrom(other);
        return this;
      }
    }
    
    public override Builder MergeFrom(PlayerInfo other) {
      if (other == global::PlayerInfo.DefaultInstance) return this;
      if (other.HasTypeName) {
        TypeName = other.TypeName;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasEmail) {
        Email = other.Email;
      }
      if (other.HasCheckSum) {
        CheckSum = other.CheckSum;
      }
      this.MergeUnknownFields(other.UnknownFields);
      return this;
    }
    
    public override Builder MergeFrom(pb::CodedInputStream input) {
      return MergeFrom(input, pb::ExtensionRegistry.Empty);
    }
    
    public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      pb::UnknownFieldSet.Builder unknownFields = null;
      while (true) {
        uint tag = input.ReadTag();
        switch (tag) {
          case 0: {
            if (unknownFields != null) {
              this.UnknownFields = unknownFields.Build();
            }
            return this;
          }
          default: {
            if (pb::WireFormat.IsEndGroupTag(tag)) {
              if (unknownFields != null) {
                this.UnknownFields = unknownFields.Build();
              }
              return this;
            }
            if (unknownFields == null) {
              unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
            }
            ParseUnknownField(input, unknownFields, extensionRegistry, tag);
            break;
          }
          case 10: {
            TypeName = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            Email = input.ReadString();
            break;
          }
          case 32: {
            CheckSum = input.ReadInt32();
            break;
          }
        }
      }
    }
    
    
    public bool HasTypeName {
      get { return result.HasTypeName; }
    }
    public string TypeName {
      get { return result.TypeName; }
      set { SetTypeName(value); }
    }
    public Builder SetTypeName(string value) {
      pb::ThrowHelper.ThrowIfNull(value, "value");
      result.hasTypeName = true;
      result.typeName_ = value;
      return this;
    }
    public Builder ClearTypeName() {
      result.hasTypeName = false;
      result.typeName_ = "PlayerInfo";
      return this;
    }
    
    public bool HasName {
      get { return result.HasName; }
    }
    public string Name {
      get { return result.Name; }
      set { SetName(value); }
    }
    public Builder SetName(string value) {
      pb::ThrowHelper.ThrowIfNull(value, "value");
      result.hasName = true;
      result.name_ = value;
      return this;
    }
    public Builder ClearName() {
      result.hasName = false;
      result.name_ = "";
      return this;
    }
    
    public bool HasEmail {
      get { return result.HasEmail; }
    }
    public string Email {
      get { return result.Email; }
      set { SetEmail(value); }
    }
    public Builder SetEmail(string value) {
      pb::ThrowHelper.ThrowIfNull(value, "value");
      result.hasEmail = true;
      result.email_ = value;
      return this;
    }
    public Builder ClearEmail() {
      result.hasEmail = false;
      result.email_ = "";
      return this;
    }
    
    public bool HasCheckSum {
      get { return result.HasCheckSum; }
    }
    public int CheckSum {
      get { return result.CheckSum; }
      set { SetCheckSum(value); }
    }
    public Builder SetCheckSum(int value) {
      result.hasCheckSum = true;
      result.checkSum_ = value;
      return this;
    }
    public Builder ClearCheckSum() {
      result.hasCheckSum = false;
      result.checkSum_ = 0;
      return this;
    }
  }
  static PlayerInfo() {
    object.ReferenceEquals(global::Proto.PlayerInfo.Descriptor, null);
  }
}

#endregion

