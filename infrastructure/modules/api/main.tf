resource "azurerm_service_plan" "main_plan" {
  name                = "asp-${var.app_name}"
  resource_group_name = var.resource_group_name
  location            = var.location
  os_type             = "Linux"
  sku_name            = "F1"
}

resource "azurerm_linux_web_app" "main_web_app" {
  name                = "was-${var.app_name}"
  resource_group_name = var.resource_group_name
  location            = var.location
  service_plan_id     = azurerm_service_plan.main_plan.id

  https_only = true

  site_config {
    application_stack {
      dotnet_version = "8.0"
    }
    always_on = false
  }
}
