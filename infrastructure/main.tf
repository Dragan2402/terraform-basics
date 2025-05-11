resource "azurerm_resource_group" "main" {
  name     = "${var.app_name}-rg"
  location = var.location
}

module "static-webapp" {
  source              = "./modules/static-webapp"
  app_name            = "swa-${var.app_name}"
  location            = var.location
  resource_group_name = azurerm_resource_group.main.name
}

module "web-app-api" {
  source              = "./modules/api"
  app_name            = var.app_name
  location            = var.location
  resource_group_name = azurerm_resource_group.main.name
}
