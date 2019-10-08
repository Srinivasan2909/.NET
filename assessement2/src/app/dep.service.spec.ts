import { TestBed } from '@angular/core/testing';

import { DepService } from './dep.service';

describe('DepService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: DepService = TestBed.get(DepService);
    expect(service).toBeTruthy();
  });
});
