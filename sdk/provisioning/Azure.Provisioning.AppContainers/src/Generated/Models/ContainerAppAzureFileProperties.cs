// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Azure File Properties.
/// </summary>
public partial class ContainerAppAzureFileProperties : ProvisionableConstruct
{
    /// <summary>
    /// Storage account name for azure file.
    /// </summary>
    public BicepValue<string> AccountName 
    {
        get { Initialize(); return _accountName!; }
        set { Initialize(); _accountName!.Assign(value); }
    }
    private BicepValue<string>? _accountName;

    /// <summary>
    /// Storage account key for azure file.
    /// </summary>
    public BicepValue<string> AccountKey 
    {
        get { Initialize(); return _accountKey!; }
        set { Initialize(); _accountKey!.Assign(value); }
    }
    private BicepValue<string>? _accountKey;

    /// <summary>
    /// Access mode for storage.
    /// </summary>
    public BicepValue<ContainerAppAccessMode> AccessMode 
    {
        get { Initialize(); return _accessMode!; }
        set { Initialize(); _accessMode!.Assign(value); }
    }
    private BicepValue<ContainerAppAccessMode>? _accessMode;

    /// <summary>
    /// Azure file share name.
    /// </summary>
    public BicepValue<string> ShareName 
    {
        get { Initialize(); return _shareName!; }
        set { Initialize(); _shareName!.Assign(value); }
    }
    private BicepValue<string>? _shareName;

    /// <summary>
    /// Creates a new ContainerAppAzureFileProperties.
    /// </summary>
    public ContainerAppAzureFileProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppAzureFileProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _accountName = DefineProperty<string>("AccountName", ["accountName"]);
        _accountKey = DefineProperty<string>("AccountKey", ["accountKey"]);
        _accessMode = DefineProperty<ContainerAppAccessMode>("AccessMode", ["accessMode"]);
        _shareName = DefineProperty<string>("ShareName", ["shareName"]);
    }
}
