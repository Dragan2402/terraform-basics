variable "app_name" {
  type        = string
  description = "Represents app name, allowed only letters and dashes, name will be used both for service plan and web app name"
  validation {
    condition     = can(regex("^[a-zA-Z-]+$", var.app_name))
    error_message = "App name must contain only letters and dashes"
  }
}

variable "resource_group_name" {
  type        = string
  description = "Represents resource group name"
}

variable "location" {
  type        = string
  description = "Represents location, allowed only values = westeurope, northeurope, default value = westeurope"
  default     = "westeurope"
  validation {
    condition     = contains(["westeurope", "northeurope"], var.location)
    error_message = "Location must be either westeurope or northeurope"
  }
}
