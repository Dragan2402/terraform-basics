output "static_webapp_id" {
  value       = module.static-webapp.static_webapp_id
  description = "Id of the static web app"
}

output "static_webapp_name" {
  value       = module.static-webapp.static_webapp_name
  description = "Name of the static web app"
}

output "resource_group_id" {
  value       = azurerm_resource_group.main.id
  description = "Id of the resource group"
}

output "resource_group_name" {
  value       = azurerm_resource_group.main.name
  description = "Name of the resource group"
}
