 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44375/',
  redirectUri: baseUrl,
  clientId: 'Bookshop_App',
  responseType: 'code',
  scope: 'offline_access Bookshop',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Bookshop',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44375',
      rootNamespace: 'Acme.Bookshop',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
