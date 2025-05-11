resource "azurerm_static_web_app" "static_webapp" {
  name                = var.app_name
  location            = var.location
  resource_group_name = var.resource_group_name
}
