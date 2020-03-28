import { TestBed } from '@angular/core/testing';

import { CouponserviceService } from './couponservice.service';

describe('CouponserviceService', () => {
  let service: CouponserviceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CouponserviceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
