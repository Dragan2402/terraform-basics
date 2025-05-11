# Static Webapp Module

This Terraform module deploys a static web application to cloud storage with CDN capabilities. It's designed to be reusable and configurable for different static web application deployments.

## Features

- Static website hosting
- CDN integration for improved performance
- Custom domain support
- SSL/TLS certificate management
- Basic security configurations

## Usage

```hcl
module "static_webapp" {
  source = "./modules/static-webapp"
  app_name         = "my-webapp"
  environment      = "production"
  location         = "eastus"
  custom_domain    = "www.example.com"
  enable_ssl       = true
  storage_account_tier = "Standard"
}
```

## Inputs

| Name                | Description                 | Type                                 | Default      | Required |
| ------------------- | --------------------------- | ------------------------------------ | ------------ | :------: |
| app_name            | Name of the app             | `string`                             | n/a          |   yes    |
| location            | Azure region for deployment | `string - [westeurope, northeurope]` | `westeurope` |    no    |
| resource_group_name | Name of the rersource group | `string`                             | `null`       |   yes    |

## Outputs

| Name         | Description                                                                                                                              |
| ------------ | ---------------------------------------------------------------------------------------------------------------------------------------- |
| web_app_id   | The Id of the static web app                                                                                                             |
| web_app_key  | The API key of this Static Web App, which is used for later interacting with this Static Web App from other clients, e.g. GitHub Action. |
| web_app_name | The name of the web app                                                                                                                  |

## Example

```hcl
module "static-webapp" {
  source              = "./modules/static-webapp"
  app_name            = "swa-${var.app_name}"
  location            = var.location
  resource_group_name = azurerm_resource_group.main.name
}

output "static_webapp_id" {
  value       = module.static-webapp.static_webapp_id
  description = "Id of the static web app"
}

output "static_webapp_name" {
  value       = module.static-webapp.static_webapp_name
  description = "Name of the static web app"
}
```

## Dependencies

- Azure Provider

## License

MIT License

Copyright (c) 2024

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
