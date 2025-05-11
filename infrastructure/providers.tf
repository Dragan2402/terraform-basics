# Configure the Azure provider
terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "~> 4.28.0"
    }
  }

  required_version = ">= 1.10.0"
}

provider "azurerm" {
  features {}
  subscription_id = var.subscription_id
}
