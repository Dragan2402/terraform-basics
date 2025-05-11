variable "app_name" {
  type        = string
  description = "Represents app name, allowed only letters, default value = weather"
  default     = "weather"
  validation {
    condition     = can(regex("^[a-zA-Z]+$", var.app_name))
    error_message = "App name must contain only letters"
  }
}

variable "location" {
  type        = string
  description = "Represents location, allowed only values = westeurope, northeurope, default value = westeurope"
  default     = "westeurope"
}

variable "subscription_id" {
  description = "The subscription ID to use for Azure resources"
  type        = string
}
