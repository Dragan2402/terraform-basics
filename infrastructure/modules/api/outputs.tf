output "service_plan_name" {
  value       = azurerm_service_plan.main_plan.name
  description = "Represents service plan name"
}

output "service_plan_id" {
  value       = azurerm_service_plan.main_plan.id
  description = "Represents service plan id"
}

output "web_app_name" {
  value       = azurerm_linux_web_app.main_web_app.name
  description = "Represents web app name"
}


output "web_app_id" {
  value       = azurerm_linux_web_app.main_web_app.id
  description = "Represents web app id"
}


output "web_app_default_host_name" {
  value       = azurerm_linux_web_app.main_web_app.default_hostname
  description = "Represents web app default host name"
}
