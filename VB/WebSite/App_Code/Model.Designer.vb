﻿'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data.EntityClient
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.Xml.Serialization

<Assembly: EdmSchemaAttribute()>
Namespace NorthwindModel
	#Region "Contexts"

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	Partial Public Class NorthwindEntities
		Inherits ObjectContext
		#Region "Constructors"

		''' <summary>
		''' Initializes a new NorthwindEntities object using the connection string found in the 'NorthwindEntities' section of the application configuration file.
		''' </summary>
		Public Sub New()
			MyBase.New("name=NorthwindEntities", "NorthwindEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		''' <summary>
		''' Initialize a new NorthwindEntities object.
		''' </summary>
		Public Sub New(ByVal connectionString As String)
			MyBase.New(connectionString, "NorthwindEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		''' <summary>
		''' Initialize a new NorthwindEntities object.
		''' </summary>
		Public Sub New(ByVal connection As EntityConnection)
			MyBase.New(connection, "NorthwindEntities")
			Me.ContextOptions.LazyLoadingEnabled = True
			OnContextCreated()
		End Sub

		#End Region

		#Region "Partial Methods"

		Partial Private Sub OnContextCreated()
		End Sub

		#End Region

		#Region "ObjectSet Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		Public ReadOnly Property Orders() As ObjectSet(Of Order)
			Get
				If (_Orders Is Nothing) Then
					_Orders = MyBase.CreateObjectSet(Of Order)("Orders")
				End If
				Return _Orders
			End Get
		End Property
		Private _Orders As ObjectSet(Of Order)

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		Public ReadOnly Property Invoices() As ObjectSet(Of Invoice)
			Get
				If (_Invoices Is Nothing) Then
					_Invoices = MyBase.CreateObjectSet(Of Invoice)("Invoices")
				End If
				Return _Invoices
			End Get
		End Property
		Private _Invoices As ObjectSet(Of Invoice)

		#End Region

		#Region "AddTo Methods"

		''' <summary>
		''' Deprecated Method for adding a new object to the Orders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
		''' </summary>
		Public Sub AddToOrders(ByVal order As Order)
			MyBase.AddObject("Orders", order)
		End Sub

		''' <summary>
		''' Deprecated Method for adding a new object to the Invoices EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
		''' </summary>
		Public Sub AddToInvoices(ByVal invoice As Invoice)
			MyBase.AddObject("Invoices", invoice)
		End Sub

		#End Region

	End Class

	#End Region

	#Region "Entities"

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	<EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="Invoice"), Serializable(), DataContractAttribute(IsReference:=True)> _
	Partial Public Class Invoice
		Inherits EntityObject
		#Region "Factory Method"

		''' <summary>
		''' Create a new Invoice object.
		''' </summary>
		''' <param name="customerName">Initial value of the CustomerName property.</param>
		''' <param name="salesperson">Initial value of the Salesperson property.</param>
		''' <param name="orderID">Initial value of the OrderID property.</param>
		''' <param name="shipperName">Initial value of the ShipperName property.</param>
		''' <param name="productID">Initial value of the ProductID property.</param>
		''' <param name="productName">Initial value of the ProductName property.</param>
		''' <param name="unitPrice">Initial value of the UnitPrice property.</param>
		''' <param name="quantity">Initial value of the Quantity property.</param>
		''' <param name="discount">Initial value of the Discount property.</param>
		Public Shared Function CreateInvoice(ByVal customerName As Global.System.String, ByVal salesperson As Global.System.String, ByVal orderID As Global.System.Int32, ByVal shipperName As Global.System.String, ByVal productID As Global.System.Int32, ByVal productName As Global.System.String, ByVal unitPrice As Global.System.Decimal, ByVal quantity As Global.System.Int16, ByVal discount As Global.System.Single) As Invoice
			Dim invoice As New Invoice()
			invoice.CustomerName = customerName
			invoice.Salesperson = salesperson
			invoice.OrderID = orderID
			invoice.ShipperName = shipperName
			invoice.ProductID = productID
			invoice.ProductName = productName
			invoice.UnitPrice = unitPrice
			invoice.Quantity = quantity
			invoice.Discount = discount
			Return invoice
		End Function

		#End Region

		#Region "Primitive Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipName() As Global.System.String
			Get
				Return _ShipName
			End Get
			Set(ByVal value As System.String)
				OnShipNameChanging(value)
				ReportPropertyChanging("ShipName")
				_ShipName = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipName")
				OnShipNameChanged()
			End Set
		End Property
		Private _ShipName As Global.System.String
		Partial Private Sub OnShipNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipAddress() As Global.System.String
			Get
				Return _ShipAddress
			End Get
			Set(ByVal value As System.String)
				OnShipAddressChanging(value)
				ReportPropertyChanging("ShipAddress")
				_ShipAddress = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipAddress")
				OnShipAddressChanged()
			End Set
		End Property
		Private _ShipAddress As Global.System.String
		Partial Private Sub OnShipAddressChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipAddressChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipCity() As Global.System.String
			Get
				Return _ShipCity
			End Get
			Set(ByVal value As System.String)
				OnShipCityChanging(value)
				ReportPropertyChanging("ShipCity")
				_ShipCity = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipCity")
				OnShipCityChanged()
			End Set
		End Property
		Private _ShipCity As Global.System.String
		Partial Private Sub OnShipCityChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipCityChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipRegion() As Global.System.String
			Get
				Return _ShipRegion
			End Get
			Set(ByVal value As System.String)
				OnShipRegionChanging(value)
				ReportPropertyChanging("ShipRegion")
				_ShipRegion = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipRegion")
				OnShipRegionChanged()
			End Set
		End Property
		Private _ShipRegion As Global.System.String
		Partial Private Sub OnShipRegionChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipRegionChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipPostalCode() As Global.System.String
			Get
				Return _ShipPostalCode
			End Get
			Set(ByVal value As System.String)
				OnShipPostalCodeChanging(value)
				ReportPropertyChanging("ShipPostalCode")
				_ShipPostalCode = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipPostalCode")
				OnShipPostalCodeChanged()
			End Set
		End Property
		Private _ShipPostalCode As Global.System.String
		Partial Private Sub OnShipPostalCodeChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipPostalCodeChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipCountry() As Global.System.String
			Get
				Return _ShipCountry
			End Get
			Set(ByVal value As System.String)
				OnShipCountryChanging(value)
				ReportPropertyChanging("ShipCountry")
				_ShipCountry = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipCountry")
				OnShipCountryChanged()
			End Set
		End Property
		Private _ShipCountry As Global.System.String
		Partial Private Sub OnShipCountryChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipCountryChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property CustomerID() As Global.System.String
			Get
				Return _CustomerID
			End Get
			Set(ByVal value As System.String)
				OnCustomerIDChanging(value)
				ReportPropertyChanging("CustomerID")
				_CustomerID = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("CustomerID")
				OnCustomerIDChanged()
			End Set
		End Property
		Private _CustomerID As Global.System.String
		Partial Private Sub OnCustomerIDChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnCustomerIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property CustomerName() As Global.System.String
			Get
				Return _CustomerName
			End Get
			Set(ByVal value As System.String)
				If _CustomerName <> value Then
					OnCustomerNameChanging(value)
					ReportPropertyChanging("CustomerName")
					_CustomerName = StructuralObject.SetValidValue(value, False)
					ReportPropertyChanged("CustomerName")
					OnCustomerNameChanged()
				End If
			End Set
		End Property
		Private _CustomerName As Global.System.String
		Partial Private Sub OnCustomerNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnCustomerNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Address() As Global.System.String
			Get
				Return _Address
			End Get
			Set(ByVal value As System.String)
				OnAddressChanging(value)
				ReportPropertyChanging("Address")
				_Address = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Address")
				OnAddressChanged()
			End Set
		End Property
		Private _Address As Global.System.String
		Partial Private Sub OnAddressChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnAddressChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property City() As Global.System.String
			Get
				Return _City
			End Get
			Set(ByVal value As System.String)
				OnCityChanging(value)
				ReportPropertyChanging("City")
				_City = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("City")
				OnCityChanged()
			End Set
		End Property
		Private _City As Global.System.String
		Partial Private Sub OnCityChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnCityChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Region() As Global.System.String
			Get
				Return _Region
			End Get
			Set(ByVal value As System.String)
				OnRegionChanging(value)
				ReportPropertyChanging("Region")
				_Region = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Region")
				OnRegionChanged()
			End Set
		End Property
		Private _Region As Global.System.String
		Partial Private Sub OnRegionChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnRegionChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property PostalCode() As Global.System.String
			Get
				Return _PostalCode
			End Get
			Set(ByVal value As System.String)
				OnPostalCodeChanging(value)
				ReportPropertyChanging("PostalCode")
				_PostalCode = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("PostalCode")
				OnPostalCodeChanged()
			End Set
		End Property
		Private _PostalCode As Global.System.String
		Partial Private Sub OnPostalCodeChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnPostalCodeChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Country() As Global.System.String
			Get
				Return _Country
			End Get
			Set(ByVal value As System.String)
				OnCountryChanging(value)
				ReportPropertyChanging("Country")
				_Country = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("Country")
				OnCountryChanged()
			End Set
		End Property
		Private _Country As Global.System.String
		Partial Private Sub OnCountryChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnCountryChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property Salesperson() As Global.System.String
			Get
				Return _Salesperson
			End Get
			Set(ByVal value As System.String)
				If _Salesperson <> value Then
					OnSalespersonChanging(value)
					ReportPropertyChanging("Salesperson")
					_Salesperson = StructuralObject.SetValidValue(value, False)
					ReportPropertyChanged("Salesperson")
					OnSalespersonChanged()
				End If
			End Set
		End Property
		Private _Salesperson As Global.System.String
		Partial Private Sub OnSalespersonChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnSalespersonChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property OrderID() As Global.System.Int32
			Get
				Return _OrderID
			End Get
			Set(ByVal value As System.Int32)
				If _OrderID <> value Then
					OnOrderIDChanging(value)
					ReportPropertyChanging("OrderID")
					_OrderID = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("OrderID")
					OnOrderIDChanged()
				End If
			End Set
		End Property
		Private _OrderID As Global.System.Int32
		Partial Private Sub OnOrderIDChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnOrderIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property OrderDate() As Nullable(Of Global.System.DateTime)
			Get
				Return _OrderDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				OnOrderDateChanging(value)
				ReportPropertyChanging("OrderDate")
				_OrderDate = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("OrderDate")
				OnOrderDateChanged()
			End Set
		End Property
		Private _OrderDate As Nullable(Of Global.System.DateTime)
		Partial Private Sub OnOrderDateChanging(ByVal value As Nullable(Of Global.System.DateTime))
		End Sub
		Partial Private Sub OnOrderDateChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property RequiredDate() As Nullable(Of Global.System.DateTime)
			Get
				Return _RequiredDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				OnRequiredDateChanging(value)
				ReportPropertyChanging("RequiredDate")
				_RequiredDate = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("RequiredDate")
				OnRequiredDateChanged()
			End Set
		End Property
		Private _RequiredDate As Nullable(Of Global.System.DateTime)
		Partial Private Sub OnRequiredDateChanging(ByVal value As Nullable(Of Global.System.DateTime))
		End Sub
		Partial Private Sub OnRequiredDateChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShippedDate() As Nullable(Of Global.System.DateTime)
			Get
				Return _ShippedDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				OnShippedDateChanging(value)
				ReportPropertyChanging("ShippedDate")
				_ShippedDate = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("ShippedDate")
				OnShippedDateChanged()
			End Set
		End Property
		Private _ShippedDate As Nullable(Of Global.System.DateTime)
		Partial Private Sub OnShippedDateChanging(ByVal value As Nullable(Of Global.System.DateTime))
		End Sub
		Partial Private Sub OnShippedDateChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property ShipperName() As Global.System.String
			Get
				Return _ShipperName
			End Get
			Set(ByVal value As System.String)
				If _ShipperName <> value Then
					OnShipperNameChanging(value)
					ReportPropertyChanging("ShipperName")
					_ShipperName = StructuralObject.SetValidValue(value, False)
					ReportPropertyChanged("ShipperName")
					OnShipperNameChanged()
				End If
			End Set
		End Property
		Private _ShipperName As Global.System.String
		Partial Private Sub OnShipperNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipperNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property ProductID() As Global.System.Int32
			Get
				Return _ProductID
			End Get
			Set(ByVal value As System.Int32)
				If _ProductID <> value Then
					OnProductIDChanging(value)
					ReportPropertyChanging("ProductID")
					_ProductID = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("ProductID")
					OnProductIDChanged()
				End If
			End Set
		End Property
		Private _ProductID As Global.System.Int32
		Partial Private Sub OnProductIDChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnProductIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property ProductName() As Global.System.String
			Get
				Return _ProductName
			End Get
			Set(ByVal value As System.String)
				If _ProductName <> value Then
					OnProductNameChanging(value)
					ReportPropertyChanging("ProductName")
					_ProductName = StructuralObject.SetValidValue(value, False)
					ReportPropertyChanged("ProductName")
					OnProductNameChanged()
				End If
			End Set
		End Property
		Private _ProductName As Global.System.String
		Partial Private Sub OnProductNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnProductNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property UnitPrice() As Global.System.Decimal
			Get
				Return _UnitPrice
			End Get
			Set(ByVal value As System.Decimal)
				If _UnitPrice <> value Then
					OnUnitPriceChanging(value)
					ReportPropertyChanging("UnitPrice")
					_UnitPrice = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("UnitPrice")
					OnUnitPriceChanged()
				End If
			End Set
		End Property
		Private _UnitPrice As Global.System.Decimal
		Partial Private Sub OnUnitPriceChanging(ByVal value As Global.System.Decimal)
		End Sub
		Partial Private Sub OnUnitPriceChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property Quantity() As Global.System.Int16
			Get
				Return _Quantity
			End Get
			Set(ByVal value As System.Int16)
				If _Quantity <> value Then
					OnQuantityChanging(value)
					ReportPropertyChanging("Quantity")
					_Quantity = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("Quantity")
					OnQuantityChanged()
				End If
			End Set
		End Property
		Private _Quantity As Global.System.Int16
		Partial Private Sub OnQuantityChanging(ByVal value As Global.System.Int16)
		End Sub
		Partial Private Sub OnQuantityChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property Discount() As Global.System.Single
			Get
				Return _Discount
			End Get
			Set(ByVal value As System.Single)
				If _Discount <> value Then
					OnDiscountChanging(value)
					ReportPropertyChanging("Discount")
					_Discount = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("Discount")
					OnDiscountChanged()
				End If
			End Set
		End Property
		Private _Discount As Global.System.Single
		Partial Private Sub OnDiscountChanging(ByVal value As Global.System.Single)
		End Sub
		Partial Private Sub OnDiscountChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ExtendedPrice() As Nullable(Of Global.System.Decimal)
			Get
				Return _ExtendedPrice
			End Get
			Set(ByVal value As Nullable(Of System.Decimal))
				OnExtendedPriceChanging(value)
				ReportPropertyChanging("ExtendedPrice")
				_ExtendedPrice = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("ExtendedPrice")
				OnExtendedPriceChanged()
			End Set
		End Property
		Private _ExtendedPrice As Nullable(Of Global.System.Decimal)
		Partial Private Sub OnExtendedPriceChanging(ByVal value As Nullable(Of Global.System.Decimal))
		End Sub
		Partial Private Sub OnExtendedPriceChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Freight() As Nullable(Of Global.System.Decimal)
			Get
				Return _Freight
			End Get
			Set(ByVal value As Nullable(Of System.Decimal))
				OnFreightChanging(value)
				ReportPropertyChanging("Freight")
				_Freight = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Freight")
				OnFreightChanged()
			End Set
		End Property
		Private _Freight As Nullable(Of Global.System.Decimal)
		Partial Private Sub OnFreightChanging(ByVal value As Nullable(Of Global.System.Decimal))
		End Sub
		Partial Private Sub OnFreightChanged()
		End Sub

		#End Region


	End Class

	''' <summary>
	''' No Metadata Documentation available.
	''' </summary>
	<EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="Order"), Serializable(), DataContractAttribute(IsReference:=True)> _
	Partial Public Class Order
		Inherits EntityObject
		#Region "Factory Method"

		''' <summary>
		''' Create a new Order object.
		''' </summary>
		''' <param name="orderID">Initial value of the OrderID property.</param>
		Public Shared Function CreateOrder(ByVal orderID As Global.System.Int32) As Order
			Dim order As New Order()
			order.OrderID = orderID
			Return order
		End Function

		#End Region

		#Region "Primitive Properties"

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=True, IsNullable:=False), DataMemberAttribute()> _
		Public Property OrderID() As Global.System.Int32
			Get
				Return _OrderID
			End Get
			Set(ByVal value As System.Int32)
				If _OrderID <> value Then
					OnOrderIDChanging(value)
					ReportPropertyChanging("OrderID")
					_OrderID = StructuralObject.SetValidValue(value)
					ReportPropertyChanged("OrderID")
					OnOrderIDChanged()
				End If
			End Set
		End Property
		Private _OrderID As Global.System.Int32
		Partial Private Sub OnOrderIDChanging(ByVal value As Global.System.Int32)
		End Sub
		Partial Private Sub OnOrderIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property CustomerID() As Global.System.String
			Get
				Return _CustomerID
			End Get
			Set(ByVal value As System.String)
				OnCustomerIDChanging(value)
				ReportPropertyChanging("CustomerID")
				_CustomerID = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("CustomerID")
				OnCustomerIDChanged()
			End Set
		End Property
		Private _CustomerID As Global.System.String
		Partial Private Sub OnCustomerIDChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnCustomerIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property EmployeeID() As Nullable(Of Global.System.Int32)
			Get
				Return _EmployeeID
			End Get
			Set(ByVal value As Nullable(Of System.Int32))
				OnEmployeeIDChanging(value)
				ReportPropertyChanging("EmployeeID")
				_EmployeeID = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("EmployeeID")
				OnEmployeeIDChanged()
			End Set
		End Property
		Private _EmployeeID As Nullable(Of Global.System.Int32)
		Partial Private Sub OnEmployeeIDChanging(ByVal value As Nullable(Of Global.System.Int32))
		End Sub
		Partial Private Sub OnEmployeeIDChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property OrderDate() As Nullable(Of Global.System.DateTime)
			Get
				Return _OrderDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				OnOrderDateChanging(value)
				ReportPropertyChanging("OrderDate")
				_OrderDate = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("OrderDate")
				OnOrderDateChanged()
			End Set
		End Property
		Private _OrderDate As Nullable(Of Global.System.DateTime)
		Partial Private Sub OnOrderDateChanging(ByVal value As Nullable(Of Global.System.DateTime))
		End Sub
		Partial Private Sub OnOrderDateChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property RequiredDate() As Nullable(Of Global.System.DateTime)
			Get
				Return _RequiredDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				OnRequiredDateChanging(value)
				ReportPropertyChanging("RequiredDate")
				_RequiredDate = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("RequiredDate")
				OnRequiredDateChanged()
			End Set
		End Property
		Private _RequiredDate As Nullable(Of Global.System.DateTime)
		Partial Private Sub OnRequiredDateChanging(ByVal value As Nullable(Of Global.System.DateTime))
		End Sub
		Partial Private Sub OnRequiredDateChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShippedDate() As Nullable(Of Global.System.DateTime)
			Get
				Return _ShippedDate
			End Get
			Set(ByVal value As Nullable(Of System.DateTime))
				OnShippedDateChanging(value)
				ReportPropertyChanging("ShippedDate")
				_ShippedDate = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("ShippedDate")
				OnShippedDateChanged()
			End Set
		End Property
		Private _ShippedDate As Nullable(Of Global.System.DateTime)
		Partial Private Sub OnShippedDateChanging(ByVal value As Nullable(Of Global.System.DateTime))
		End Sub
		Partial Private Sub OnShippedDateChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipVia() As Nullable(Of Global.System.Int32)
			Get
				Return _ShipVia
			End Get
			Set(ByVal value As Nullable(Of System.Int32))
				OnShipViaChanging(value)
				ReportPropertyChanging("ShipVia")
				_ShipVia = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("ShipVia")
				OnShipViaChanged()
			End Set
		End Property
		Private _ShipVia As Nullable(Of Global.System.Int32)
		Partial Private Sub OnShipViaChanging(ByVal value As Nullable(Of Global.System.Int32))
		End Sub
		Partial Private Sub OnShipViaChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property Freight() As Nullable(Of Global.System.Decimal)
			Get
				Return _Freight
			End Get
			Set(ByVal value As Nullable(Of System.Decimal))
				OnFreightChanging(value)
				ReportPropertyChanging("Freight")
				_Freight = StructuralObject.SetValidValue(value)
				ReportPropertyChanged("Freight")
				OnFreightChanged()
			End Set
		End Property
		Private _Freight As Nullable(Of Global.System.Decimal)
		Partial Private Sub OnFreightChanging(ByVal value As Nullable(Of Global.System.Decimal))
		End Sub
		Partial Private Sub OnFreightChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipName() As Global.System.String
			Get
				Return _ShipName
			End Get
			Set(ByVal value As System.String)
				OnShipNameChanging(value)
				ReportPropertyChanging("ShipName")
				_ShipName = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipName")
				OnShipNameChanged()
			End Set
		End Property
		Private _ShipName As Global.System.String
		Partial Private Sub OnShipNameChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipNameChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipAddress() As Global.System.String
			Get
				Return _ShipAddress
			End Get
			Set(ByVal value As System.String)
				OnShipAddressChanging(value)
				ReportPropertyChanging("ShipAddress")
				_ShipAddress = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipAddress")
				OnShipAddressChanged()
			End Set
		End Property
		Private _ShipAddress As Global.System.String
		Partial Private Sub OnShipAddressChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipAddressChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipCity() As Global.System.String
			Get
				Return _ShipCity
			End Get
			Set(ByVal value As System.String)
				OnShipCityChanging(value)
				ReportPropertyChanging("ShipCity")
				_ShipCity = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipCity")
				OnShipCityChanged()
			End Set
		End Property
		Private _ShipCity As Global.System.String
		Partial Private Sub OnShipCityChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipCityChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipRegion() As Global.System.String
			Get
				Return _ShipRegion
			End Get
			Set(ByVal value As System.String)
				OnShipRegionChanging(value)
				ReportPropertyChanging("ShipRegion")
				_ShipRegion = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipRegion")
				OnShipRegionChanged()
			End Set
		End Property
		Private _ShipRegion As Global.System.String
		Partial Private Sub OnShipRegionChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipRegionChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipPostalCode() As Global.System.String
			Get
				Return _ShipPostalCode
			End Get
			Set(ByVal value As System.String)
				OnShipPostalCodeChanging(value)
				ReportPropertyChanging("ShipPostalCode")
				_ShipPostalCode = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipPostalCode")
				OnShipPostalCodeChanged()
			End Set
		End Property
		Private _ShipPostalCode As Global.System.String
		Partial Private Sub OnShipPostalCodeChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipPostalCodeChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipCountry() As Global.System.String
			Get
				Return _ShipCountry
			End Get
			Set(ByVal value As System.String)
				OnShipCountryChanging(value)
				ReportPropertyChanging("ShipCountry")
				_ShipCountry = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipCountry")
				OnShipCountryChanged()
			End Set
		End Property
		Private _ShipCountry As Global.System.String
		Partial Private Sub OnShipCountryChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipCountryChanged()
		End Sub

		''' <summary>
		''' No Metadata Documentation available.
		''' </summary>
		<EdmScalarPropertyAttribute(EntityKeyProperty:=False, IsNullable:=True), DataMemberAttribute()> _
		Public Property ShipAdress() As Global.System.String
			Get
				Return _ShipAdress
			End Get
			Set(ByVal value As System.String)
				OnShipAdressChanging(value)
				ReportPropertyChanging("ShipAdress")
				_ShipAdress = StructuralObject.SetValidValue(value, True)
				ReportPropertyChanged("ShipAdress")
				OnShipAdressChanged()
			End Set
		End Property
		Private _ShipAdress As Global.System.String
		Partial Private Sub OnShipAdressChanging(ByVal value As Global.System.String)
		End Sub
		Partial Private Sub OnShipAdressChanged()
		End Sub

		#End Region


	End Class

	#End Region


End Namespace
