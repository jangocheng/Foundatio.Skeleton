﻿using System;
using System.Web.Http.Routing.Constraints;

namespace Foundatio.Skeleton.Api.Utility {
    public class ObjectIdsRouteConstraint : RegexRouteConstraint {
        public ObjectIdsRouteConstraint() : base(@"^[a-zA-Z\d]{24,36}(,[a-zA-Z\d]{24,36})*$") { }
    }
}