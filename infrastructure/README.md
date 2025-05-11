# Infrastructure as Code (IaC) with Terraform

This directory contains the Terraform configuration for managing our cloud infrastructure. The infrastructure is organized using a modular approach for better maintainability and reusability.

## Directory Structure

```
infrastructure/
├── modules/              # Reusable Terraform modules
│   └── static-webapp/    # Module for deploying static web applications
├── main.tf              # Main Terraform configuration
├── variables.tf         # Input variables
├── outputs.tf           # Output values
├── providers.tf         # Provider configurations
└── .gitignore          # Git ignore rules for Terraform
```

## Prerequisites

- Terraform >= 1.0.0
- Azure CLI (if using Azure)
- Appropriate cloud provider credentials

## Getting Started

1. Initialize Terraform:

   ```bash
   terraform init
   ```

2. Review the planned changes:

   ```bash
   terraform plan
   ```

3. Apply the configuration:
   ```bash
   terraform apply
   ```

## Modules

### Static Webapp Module

The `static-webapp` module is designed to deploy static web applications to cloud storage with CDN capabilities. See the module's README for detailed usage instructions.

## Variables

Key variables can be configured in `variables.tf`. Required variables must be set before applying the configuration.

## Outputs

The infrastructure outputs important information such as:

- Resource IDs
- Endpoints
- Connection strings

See `outputs.tf` for the complete list of outputs.

## Best Practices

- Use `terraform fmt -recursive` to format files
- [Optional] Use `tflint --recursive` to check for static errors
- Always review the plan before applying changes
- Use workspaces for managing different environments
- Keep sensitive values in `.tfvars` files (not committed to version control)
- Follow the naming conventions defined in the configuration

## Contributing

When making changes to the infrastructure:

1. Create a new branch
2. Make your changes
3. Test the changes using `terraform plan`
4. Submit a pull request

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
