import { TestBed } from '@angular/core/testing';

import { MathsandrandomService } from './mathsandrandom.service';

describe('MathsandrandomService', () => {
  let service: MathsandrandomService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MathsandrandomService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
