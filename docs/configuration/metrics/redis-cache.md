---
layout: default
title: Azure Cache for Redis Declaration
---

## Azure Cache for Redis - ![Availability Badge](https://img.shields.io/badge/Available%20Starting-v1.0.0-green.svg)
You can declare to scrape an Azure Cache for Redis via the `RedisCache` resource type.

The following fields need to be provided:
- `cacheName` - The name of the Redis Cache instance

All supported metrics are documented in the official [Azure Monitor documentation](https://docs.microsoft.com/en-us/azure/azure-monitor/platform/metrics-supported#microsoftcacheredis).

You can find more documentation on each metric in the Azure Cache for Redis [monitoring documentation](https://docs.microsoft.com/en-us/azure/azure-cache-for-redis/cache-how-to-monitor#available-metrics-and-reporting-intervals).

Example:
```yaml
name: redis_cache_hits
description: "The number of successful key lookups during the specified reporting interval. This maps to keyspace_hits from the Redis INFO command."
resourceType: RedisCache
cacheName: Promitor
scraping:
  schedule: "0 */2 * ? * *"
azureMetricConfiguration:
  metricName: CacheHits
  aggregation:
    type: Total
    interval: 00:01:00
```

[&larr; back to metrics declarations](/configuration/metrics)<br />
[&larr; back to introduction](/)